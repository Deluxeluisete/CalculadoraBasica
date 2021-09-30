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

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void CalcularButon_Click(object sender, RoutedEventArgs e)
        {
            try { 
            float numero1 = int.Parse(IntroducirTextBox1.Text);
            float numero2 = int.Parse(IntroducirTextBox2.Text);
                switch (IntroducirTextBox3.Text)
                {
                    case "+":
                        IntroducirTextBox4.Text = (numero1 + numero2).ToString();
                        break;
                    case "-":
                        IntroducirTextBox4.Text = (numero1 - numero2).ToString();
                        break;
                    case "*":
                        IntroducirTextBox4.Text = (numero1 * numero2).ToString();
                        break;
                    case "/":
                        IntroducirTextBox4.Text = (numero1 / numero2).ToString();
                        break;
                    default:
                        IntroducirTextBox4.Text = "Valores incorrectos";
                        break;
                }
            }
            catch (FormatException) { MessageBox.Show( "Valores incorrectos"); }
            



        }

        private void BorrarButton_Click(object sender, RoutedEventArgs e)
        {
            IntroducirTextBox1.Text = "";
            IntroducirTextBox2.Text = "";
            IntroducirTextBox3.Text = "";
            IntroducirTextBox4.Text = "";
        }

        private void IntroducirTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IntroducirTextBox3.Text == "+" || IntroducirTextBox3.Text == "-" || IntroducirTextBox3.Text == "*" || IntroducirTextBox3.Text == "/")
            {
                CalcularButton.IsEnabled = true;
            }
            else
            {
                CalcularButton.IsEnabled = false;
            }
        }
    }
}
