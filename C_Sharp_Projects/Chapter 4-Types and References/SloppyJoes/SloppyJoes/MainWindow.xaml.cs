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

namespace SloppyJoes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MenuMaker menuMaker = new MenuMaker();
            label1.Content = menuMaker.GetMenuItem();
            label2.Content = menuMaker.GetMenuItem();
            label3.Content = menuMaker.GetMenuItem();
            label4.Content = menuMaker.GetMenuItem();
            label5.Content = menuMaker.GetMenuItem();
        }
    }
}
