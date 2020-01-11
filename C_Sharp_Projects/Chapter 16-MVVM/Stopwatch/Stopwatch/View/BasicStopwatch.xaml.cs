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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Stopwatch.ViewModel;

namespace Stopwatch.View
{
    /// <summary>
    /// Interaction logic for BasicStopwatch.xaml
    /// </summary>
    public partial class BasicStopwatch : UserControl
    {
        StopwatchViewModel newViewModel;
        public BasicStopwatch()
        {
            InitializeComponent();
            newViewModel = FindResource("viewModel") as StopwatchViewModel;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            newViewModel.StartTimer();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            newViewModel.StopTimer();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            newViewModel.ResetTimer();
        }

        private void LapButton_Click(object sender, RoutedEventArgs e)
        {
            newViewModel.Lap();
        }
    }
}
