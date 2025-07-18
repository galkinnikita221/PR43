﻿using EmployeesContext_Galkin.View;
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

namespace EmployeesContext_Galkin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public View.Main = new View.Main();
        public MainWindow()
        {
            InitializeComponent();
            init = this;
            frame.Navigate(Main);
        }

        private void OpenIndex(object sender, RoutedEventArgs e) => frame.Navigate(Main);

    }
}
