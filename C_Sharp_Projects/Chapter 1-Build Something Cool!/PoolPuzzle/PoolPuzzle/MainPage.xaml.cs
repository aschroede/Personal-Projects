using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PoolPuzzle
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        bool oysterAnnoyed = false;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (oysterAnnoyed == false)
            {
                PoolPuzzle();
                oysterAnnoyed = true;
            }
            else
            {
                nicetextblock.Text = "Give the oyster a break!";
                oysterAnnoyed = false;
            }
            

        }

        public void PoolPuzzle()
        {
            int x = 0;
            string poem = "";

            while (x < 4)
            {
                poem = poem + "a";

                if (x < 1)
                {
                    poem = poem + " ";
                }

                poem = poem + "n";

                if (x > 1)
                {
                    poem = poem + " oyster";
                    x = x + 2;
                }

                if (x == 1)
                {
                    poem = poem + "noys ";
                }

                if (x < 1)
                {
                    poem = poem + "oise ";
                }
                x = x + 1;
            }
            nicetextblock.Text = poem;
        }
    }
}
