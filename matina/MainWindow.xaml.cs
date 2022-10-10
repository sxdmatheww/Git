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

namespace matina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Otrasl());
           // Manager.MainFrame = MainFrame;
        }

        private void tehbez(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page1());
            // Manager.MainFrame = MainFrame;
        }

        private void Instrument_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Instrument());
        }
    }
}
