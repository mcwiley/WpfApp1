// ***********************************************************************
// Assembly         : WpfApp1
// Author           : m_c_w
// Created          : 07-30-2019
//
// Last Modified By : m_c_w
// Last Modified On : 08-08-2019
// ***********************************************************************
// <copyright file="MainWindow.xaml.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
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
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Implements the <see cref="System.Windows.Window" />
    /// Implements the <see cref="System.Windows.Markup.IComponentConnector" />
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            FillDataGrid();
        }

        /// <summary>
        /// Handles the Click event of the Clicker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void Clicker_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is the Clicker");
        }

        /// <summary>
        /// Fills the data grid.
        /// </summary>
        public void FillDataGrid()
        {
            dg_Topics.ItemsSource = General.GetDataTEST("select * from Topics").DefaultView;

            myCombo.ItemsSource = General.GetDataTEST("select * from SubTopics").DefaultView;
            myCombo.DisplayMemberPath = "SubTopicName";
            myCombo.SelectedValuePath = "SubTopicID";

            lb_MyData.ItemsSource = General.GetDataTEST("select * from SubTopics").DefaultView;
            lb_MyData.DisplayMemberPath = "SubTopicName";

        }

        /// <summary>
        /// Handles the Click event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window myWin = new SecondWindow();
            myWin.ShowDialog();
        }
    }
}
