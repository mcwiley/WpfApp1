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
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void Clicker_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is the Clicker");
        }

        public void FillDataGrid()
        {
            dg_Topics.ItemsSource = General.GetData("select * from Topics").DefaultView;

            myCombo.ItemsSource = General.GetData("select * from SubTopics").DefaultView;
            myCombo.DisplayMemberPath = "SubTopicName";
            myCombo.SelectedValuePath = "SubTopicID";
        }

        private void MyCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window myWin = new SecondWindow();
            myWin.Show();
        }
    }
}
