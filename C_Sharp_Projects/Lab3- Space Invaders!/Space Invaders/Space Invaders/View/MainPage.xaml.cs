using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Space_Invaders.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        ViewModel.InvadersViewModel viewModel;


        public MainPage()
        {
            InitializeComponent();
            viewModel = FindResource("viewModel") as ViewModel.InvadersViewModel;
            //aboutPopup.IsOpen = false;
        }

        private void playArea_Loaded(object sender, RoutedEventArgs e)
        {
            UpdatePlayAreaSize(playArea.RenderSize);
            viewModel.StartGame(); // TODO: Double check this is the best place to start the game
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdatePlayAreaSize(new Size(e.NewSize.Width, e.NewSize.Height-160));
        }

        private void UpdatePlayAreaSize(Size newPlayAreaSize)
        {
            double targetWidth;
            double targetHeight;
            if(newPlayAreaSize.Width > newPlayAreaSize.Height)
            {
                targetWidth = newPlayAreaSize.Height * 4 / 3;
                targetHeight = newPlayAreaSize.Height;
                double leftRightMargin = (newPlayAreaSize.Width - targetWidth) / 2;
                playArea.Margin = new Thickness(leftRightMargin, 0, leftRightMargin, 0);
            }
            else
            {
                targetHeight = newPlayAreaSize.Width * 3 / 4;
                targetWidth = newPlayAreaSize.Width;
                double topBottomMargin = (newPlayAreaSize.Height - targetHeight) / 2;
                playArea.Margin = new Thickness(0, topBottomMargin, 0, topBottomMargin);
            }

            playArea.Width = targetWidth;
            playArea.Height = targetHeight;
            viewModel.PlayAreaSize = playArea.RenderSize;
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            viewModel.KeyUp(e.Key);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            viewModel.KeyDown(e.Key);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (aboutPopup.IsOpen == false)
            {
                aboutPopup.IsOpen = true;
                viewModel.Paused = true;
            }

            else
            {
                aboutPopup.IsOpen = false;
                viewModel.Paused = false;
            }
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            viewModel.Restart();
        }

        // TODO: add the score and extra lives as separate controls to the view.
        // TODO: complete the About popup
    }
}
