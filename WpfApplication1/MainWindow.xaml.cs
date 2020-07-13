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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Main_Loaded(object sender, RoutedEventArgs e)
        {
            themechanged();
            buttonbackgroundandforegroundchanged();
            lbl_title.Content = this.Title;
        }


        // DEĞİŞKENLER
        double sayi1 = 0, toplam = 0;
        char islem;
        // TEMA İÇİN RENK DEĞİŞKENLERİ
        //string themecolor = "Siyah";
        //string backgroundcolor1nd = "#003459"; // ÜSTÜNE GELİNCE
        //string backgroundcolor2nd = "#007EA7"; // NORMAL ARKA PLAN
        //string foregroundcolor1nd = "#FFFFFF"; // ÜSTÜNE GELİNCE DEĞİŞEN RENK
        //string foregroundcolor2nd = "#000000"; // NORMAL RENK

        string themecolor = "Beyaz";
        string backgroundcolor1nd = "#FFCA83"; // ÜSTÜNE GELİNCE
        string backgroundcolor2nd = "#FF9F1C"; // NORMAL ARKA PLAN
        string foregroundcolor1nd = "#FFFFFF"; // ÜSTÜNE GELİNCE DEĞİŞEN RENK
        string foregroundcolor2nd = "#000000"; // NORMAL RENK

        // TEMA DEĞİŞTİRME METHODLARI
        private void themechanged()
        {
            switch (themecolor)
            {
                case "Siyah":
                    this.Background = Brushes.Black;
                    lbl_title.Foreground = Brushes.White;
                    lbl_close.Foreground = Brushes.White;
                    break;
                case "Beyaz":
                    this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D1D1D1"));
                    textBox.Background= new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E8E8E8"));

                    break;
            }
        }
        private void buttonbackgroundandforegroundchanged()
        {
            if (backgroundcolor2nd != "#")
            {
                lbl_num_0.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_num_1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_num_2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_num_3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_num_4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_num_5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_num_6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_num_7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_num_8.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_num_9.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_c.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_ce.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_minus.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_multiply.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_comma.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_plenty.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_plus.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
                lbl_result.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            }

            //lbl_num_0.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_num_1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_num_2.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_num_3.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_num_4.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_num_5.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_num_6.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_num_7.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_num_8.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_num_9.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_c.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_ce.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_minus.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_multiply.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_comma.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_plenty.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
            //lbl_plus.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
        }
        
        

        // ÇIKIŞ BUTON RENGİ VE KAPATMA EVENTLERİ
        private void lbl_close_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        private void lbl_close_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_close.Background = Brushes.Red;
            if (Properties.Settings.Default.BackGroundThemeColor == "Beyaz")
                lbl_close.Foreground = Brushes.White;
            else
                lbl_close.Foreground = Brushes.Yellow;


        }
        private void lbl_close_MouseLeave(object sender, MouseEventArgs e)
        {
            if (themecolor=="Beyaz")
            {
                lbl_close.Foreground = Brushes.Black;
                lbl_close.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D1D1D1"));
            }
            else
            {
                lbl_close.Foreground = Brushes.White;
                lbl_close.Background = Brushes.Black;
            }
        }

        private void Window_Main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
               
                case Key.Enter:
                    lbl_result_GotFocus(e,e);
                    break;
                case Key.NumPad0:
                    lbl_num_0_GotFocus(e,e);
                    break;
                case Key.NumPad1:
                    lbl_num_1_GotFocus(e, e);
                    break;
                case Key.NumPad2:
                    lbl_num_2_GotFocus(e, e);
                    break;
                case Key.NumPad3:
                    lbl_num_3_GotFocus(e, e);
                    break;
                case Key.NumPad4:
                    lbl_num_4_GotFocus(e, e);
                    break;
                case Key.NumPad5:
                    lbl_num_5_GotFocus(e, e);
                    break;
                case Key.NumPad6:
                    lbl_num_6_GotFocus(e, e);
                    break;
                case Key.NumPad7:
                    lbl_num_7_GotFocus(e, e);
                    break;
                case Key.NumPad8:
                    lbl_num_8_GotFocus(e, e);
                    break;
                case Key.NumPad9:
                    lbl_num_9_GotFocus(e, e);
                    break;
                case Key.Multiply:
                    lbl_multiply_GotFocus(e, e);
                    break;
                case Key.Add:
                    lbl_plus_GotFocus(e, e);
                    break;
                case Key.Subtract:
                    lbl_minus_GotFocus(e, e);
                    break;
                case Key.Divide:
                    lbl_plenty_GotFocus(e, e);
                    break;
                case Key.Back:
                    textBox.Undo();
                    break;
                case Key.Decimal:
                    lbl_comma_GotFocus(e,e);
                    break;
                case Key.Delete:
                    lbl_c_GotFocus(e, e);
                    break;
            }
        } // BASILAN TUŞLARI OKUYOR.
        private void numberadd(char number)
        {
            if (textBox.Text == "0")
                textBox.Clear();
            textBox.Text += number;

        }




        // İŞLEM
        private void lbl_num_0_GotFocus(object sender, RoutedEventArgs e)
        {
            numberadd('0');
        }
        private void lbl_num_1_GotFocus(object sender, RoutedEventArgs e)
        {
            numberadd('1');
        }
        private void lbl_num_2_GotFocus(object sender, RoutedEventArgs e)
        {
            numberadd('2');
        }
        private void lbl_num_3_GotFocus(object sender, RoutedEventArgs e)
        {
            numberadd('3');
        }
        private void lbl_num_4_GotFocus(object sender, RoutedEventArgs e)
        {
            numberadd('4');
        }
        private void lbl_num_5_GotFocus(object sender, RoutedEventArgs e)
        {
            numberadd('5');
        }
        private void lbl_num_6_GotFocus(object sender, RoutedEventArgs e)
        {
            numberadd('6');
        }
        private void lbl_num_7_GotFocus(object sender, RoutedEventArgs e)
        {
            numberadd('7');
        }
        private void lbl_num_8_GotFocus(object sender, RoutedEventArgs e)
        {
            numberadd('8');
        }
        private void lbl_num_9_GotFocus(object sender, RoutedEventArgs e)
        {
            numberadd('9');
        }
        private void lbl_comma_GotFocus(object sender, RoutedEventArgs e)
        {
            numberadd(',');
        }
        private void lbl_plus_GotFocus(object sender, RoutedEventArgs e)
        {
            sayi1 = double.Parse(textBox.Text);
            textBox.Clear();
            islem = '+';
        }
        private void lbl_multiply_GotFocus(object sender, RoutedEventArgs e)
        {
            sayi1 = double.Parse(textBox.Text);
            textBox.Clear();
            islem = '*';
        }
        private void lbl_minus_GotFocus(object sender, RoutedEventArgs e)
        {
            sayi1 = double.Parse(textBox.Text);
            textBox.Clear();
            islem = '-';
        }
        private void lbl_plenty_GotFocus(object sender, RoutedEventArgs e)
        {
            sayi1 = double.Parse(textBox.Text);
            textBox.Clear();
            islem = '/';
        }
        private void lbl_ce_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
        }
        private void lbl_c_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            sayi1 = 0;
            toplam = 0;
        }
        private void lbl_result_GotFocus(object sender, RoutedEventArgs e)
        {
            switch (islem)
            {
                case '+':
                    toplam = sayi1 + double.Parse(textBox.Text);
                    break;
                case '-':
                    toplam = sayi1 - double.Parse(textBox.Text);
                    break;
                case '*':
                    toplam = sayi1 * double.Parse(textBox.Text);
                    break;
                case '/':
                    toplam = sayi1 / double.Parse(textBox.Text);
                    break;
            }
            lbl_history.Content = "Geçmiş: "+sayi1.ToString() + " " + islem + " " + textBox.Text + " = " + toplam;
            textBox.Text = toplam.ToString();
        }




        // TASARIM
        private void lbl_num_0_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_num_0.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_num_0.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
        }
        private void lbl_num_0_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_num_0.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_num_0.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));

        }
        private void lbl_comma_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_comma.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_comma.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));

        }
        private void lbl_comma_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_comma.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_comma.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));
        }
        private void lbl_num_1_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_num_1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_num_1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));

        }
        private void lbl_num_1_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_num_1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_num_1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));

        }
        private void lbl_num_2_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_num_2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_num_2.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));

        }
        private void lbl_num_2_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_num_2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_num_2.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));

        }
        private void lbl_num_3_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_num_3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_num_3.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));


        }
        private void lbl_num_3_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_num_3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_num_3.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));

        }
        private void lbl_minus_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_minus.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_minus.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));


        }
        private void lbl_minus_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_minus.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_minus.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));

        }
        private void lbl_num_4_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_num_4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_num_4.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));

        }
        private void lbl_num_4_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_num_4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_num_4.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));

        }
        private void lbl_num_5_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_num_5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_num_5.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));

        }
        private void lbl_num_5_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_num_5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_num_5.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));

        }
        private void lbl_num_6_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_num_6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_num_6.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
        }
        private void lbl_num_6_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_num_6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_num_6.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));

        }
        private void lbl_multiply_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_multiply.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_multiply.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
        }
        private void lbl_multiply_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_multiply.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_multiply.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));

        }
        private void lbl_num_7_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_num_7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_num_7.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));

        }
        private void lbl_num_7_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_num_7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_num_7.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));

        }
        private void lbl_num_8_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_num_8.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_num_8.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
        }
        private void lbl_num_8_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_num_8.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_num_8.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));
        }
        private void lbl_num_9_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_num_9.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_num_9.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));

        }
        private void lbl_num_9_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_num_9.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_num_9.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));
        }
        private void lbl_plenty_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_plenty.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_plenty.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
        }
        private void lbl_plenty_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_plenty.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_plenty.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));
        }
        private void lbl_ce_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_ce.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_ce.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
        }
        private void lbl_ce_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_ce.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_ce.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));
        }
        private void lbl_plus_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_plus.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_plus.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
        }
        private void lbl_plus_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_plus.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_plus.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));

        }
        private void lbl_c_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_c.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_c.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));

        }
        private void lbl_c_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_c.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_c.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));
        }
        private void lbl_result_MouseEnter(object sender, MouseEventArgs e)
        {
            lbl_result.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor1nd));
            lbl_result.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor1nd));
        }
        private void lbl_result_MouseLeave(object sender, MouseEventArgs e)
        {
            lbl_result.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(backgroundcolor2nd));
            lbl_result.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(foregroundcolor2nd));
        }
        



        // MOUSE İLE SAYI GİRME EVENTLERİ
        private void lbl_num_0_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_num_0_GotFocus(e, e);
        }
        private void lbl_num_1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_num_1_GotFocus(e, e);
        }
        private void lbl_num_2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_num_2_GotFocus(e, e);

        }
        private void lbl_num_3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_num_3_GotFocus(e, e);
        }
        private void lbl_num_4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_num_4_GotFocus(e, e);
        }
        private void lbl_num_5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_num_5_GotFocus(e, e);
        }
        private void lbl_num_6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_num_6_GotFocus(e, e);
        }
        private void lbl_num_7_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_num_7_GotFocus(e, e);
        }
        private void lbl_num_8_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_num_8_GotFocus(e, e);
        }
        private void lbl_num_9_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_num_9_GotFocus(e, e);
        }
        private void lbl_plus_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_plus_GotFocus(e,e);
        }
        private void lbl_minus_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_minus_GotFocus(e,e);
        }
        private void lbl_multiply_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_multiply_GotFocus(e, e);
        }
        private void lbl_plenty_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_plenty_GotFocus(e, e);
        }
        private void lbl_result_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_result_GotFocus(e, e);
        }
        private void lbl_comma_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_comma_GotFocus(e, e);
        }
        private void lbl_c_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_c_GotFocus(e, e);
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = (int)e.Key >= 43 || (int)e.Key <= 34 || (int)e.Key == 110;
        }

        private void lbl_ce_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbl_ce_GotFocus(e, e);
        }
    }
}
