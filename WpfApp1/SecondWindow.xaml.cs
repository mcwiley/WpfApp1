// ***********************************************************************
// Assembly         : WpfApp1
// Author           : m_c_w
// Created          : 08-02-2019
//
// Last Modified By : m_c_w
// Last Modified On : 08-08-2019
// ***********************************************************************
// <copyright file="SecondWindow.xaml.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// Implements the <see cref="System.Windows.Window" />
    /// Implements the <see cref="System.Windows.Markup.IComponentConnector" />
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    public partial class SecondWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondWindow" /> class.
        /// </summary>
        public SecondWindow()
        {
            InitializeComponent();
            FillListview();
        }

        /// <summary>
        /// Handles the Click event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Fills the listview.
        /// </summary>
        private void FillListview()
        {
            lv_Contacts.ItemsSource = General.GetDataTEST("select T.*, S.* from Topics T join SubTopics S on T.TopicID = S.TopicID").DefaultView;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            myBrowser.Navigate(new Uri("http://www.comcast.net"));
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            if (myBrowser.CanGoBack)
            {
                myBrowser.GoBack();
            }
            else
            {
                MessageBox.Show("Cannot Go back");
            }
        }
        private void GoForward_Click(object sender, RoutedEventArgs e)
        {
            if (myBrowser.CanGoForward)
            {
                myBrowser.GoForward();
            }
            else
            {
                MessageBox.Show("Cannot Go Forward");
            }
        }

    }
}
