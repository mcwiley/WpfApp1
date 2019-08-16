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
using System.Windows.Shapes;
using System.Security.Cryptography;
using System.IO;
using System.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ThirdWindow.xaml
    /// </summary>
    public partial class ThirdWindow : Window
    {
        
        public ThirdWindow()
        {
            InitializeComponent();
            txt_Pass.Focus();
        }

        private void Btn_Encrypt_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Enc.Text))
            {
                if (!string.IsNullOrEmpty(txt_Enc.Text))
                {
                    txt_Result.Text = clsEDS.EncryptString(txt_Enc.Text, txt_Pass.Text);
                }
            }
        }

        private void Btn_Decrypt_Click(object sender, RoutedEventArgs e)
        {
            string sStrDecrypted = clsEDS.DecryptString(txt_Result.Text, txt_Pass.Text);
            txt_Dec.Text = clsEDS.DecryptString(txt_Result.Text, txt_Pass.Text);

            txt_Dec.Foreground = Brushes.Red;
            if (txt_Enc.Text == txt_Dec.Text)
            {
                txt_Dec.Foreground = Brushes.LimeGreen;
            }
        }

        private void Btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            txt_Pass.Text = "";
            txt_Enc.Text = "";
            txt_Result.Text = "";
            txt_Dec.Text = "";
        }

        private void BtnProBar_Click(object sender, RoutedEventArgs e)
        {
            probar.Value = 0;
            for (int i = 0; i < 100; i++)
            {
                probar.Value++;
                Thread.Sleep(50);
            }
        }


    }
}
