﻿using System;
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

namespace Baseball_Simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BaseballSimulator baseBallSimulator;
        public MainWindow()
        {
            InitializeComponent();
            baseBallSimulator = FindResource("baseBallSimulator") as BaseballSimulator;
        }

        private void startTheGame_Click(object sender, RoutedEventArgs e)
        {
            baseBallSimulator.PlayBall();
        }
    }
}
