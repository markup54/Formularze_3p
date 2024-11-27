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

namespace Formularze_3p
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float waluta = 0;
            if(float.TryParse(waluta_textbox.Text,out waluta))
            {
                if(frank_radio.IsChecked == true)
                {
                    waluta = (float)(waluta * 0.23);
                }
                else if(dolar_radio.IsChecked == true)
                {
                    waluta = (float)(waluta * 0.25);
                }
                else if (euro_radio.IsChecked == true)
                {
                    waluta = (float)(waluta * 0.24);
                }
                MessageBox.Show(waluta.ToString());
            }
            else
            {
                MessageBox.Show("Waluta musi byc liczbą");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int bok = 0;
            float pole=0;
            int obwod = 0;
            if(int.TryParse(bok_textbox.Text,out bok))
            {
                if(figura_combobox.Text == "Kwadrat")
                {
                    pole = bok * bok;
                    obwod = 4 * bok;
                }
                else if(figura_combobox.Text == "Trójkąt")
                {
                    pole = (float)(bok * bok *Math.Sqrt(3)/4);
                    obwod = 3 * bok;
                }
            }
            else
            {
                MessageBox.Show("Bok musi byc liczbą");
            }

            if(poleCheckBox.IsChecked == true)
            {
                MessageBox.Show(pole.ToString());
            }
            if(obwodCheckBox.IsChecked == true)
            {
                MessageBox.Show(obwod.ToString());
            }


        }
    }
}
