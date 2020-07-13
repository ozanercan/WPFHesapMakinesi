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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Properties.Settings.Default.BackGroundThemeColor = comboBox.Text;
                if (txt_buttonbgcolor.Text.Substring(0, 1) == "#")
                    Properties.Settings.Default.ButtonBackGroundColor1nd = txt_buttonbgcolor.Text;
                if (txt_buttonbgcolor2.Text.Substring(0, 1) == "#")
                    Properties.Settings.Default.ButtonBackGroundColor2nd = txt_buttonbgcolor2.Text;
                if (txt_fgcolor.Text.Substring(0, 1) == "#")
                    Properties.Settings.Default.ButtonForeGroundColor1nd = txt_fgcolor.Text;
                if (txt_fgcolor2.Text.Substring(0, 1) == "#")
                    Properties.Settings.Default.ButtonForeGroundColor2nd = txt_fgcolor2.Text;
                Properties.Settings.Default.Save();
                System.Windows.Forms.MessageBox.Show("Ayarlar Kaydedildi");
            }
            catch(Exception h)
            {
                System.Windows.Forms.MessageBox.Show(h.ToString());
            }
            System.Windows.Forms.MessageBox.Show(Properties.Settings.Default.BackGroundThemeColor.ToString());


        }
    }
}
