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
using System.Windows.Shapes;

namespace Session_4
{
    /// <summary>
    /// Логика взаимодействия для Skladovshik.xaml
    /// </summary>
    public partial class Skladovshik : Window
    {
        public Skladovshik()
        {
            InitializeComponent();
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
