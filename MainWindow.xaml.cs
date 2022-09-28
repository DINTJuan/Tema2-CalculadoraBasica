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

namespace Tema2_CalculadoraBasica
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

        private void CalcularButtom_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double numero1 = int.Parse(this.PrimeraTexbox.Text);
                double numero2 = int.Parse(this.SegundaTexbox.Text);
                switch (this.TerceraTexbox.Text)
                {
                    case "*":
                        this.ResultadoTexBlock.Text = (numero1 * numero2).ToString();
                        break;
                    case "/":
                        this.ResultadoTexBlock.Text = (numero1 / numero2).ToString();
                        break;
                    case "+":
                        this.ResultadoTexBlock.Text = (numero1 + numero2).ToString();
                        break;
                    case "-":
                        this.ResultadoTexBlock.Text = (numero1 - numero2).ToString();
                        break;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Se ha producido un error. Revise los operandos.","Calculadora Basica",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void LimpiarButtom_Click(object sender, RoutedEventArgs e)
        {
            this.PrimeraTexbox.Text = "";
            this.SegundaTexbox.Text = "";
            this.TerceraTexbox.Text = "";
            this.ResultadoTexBlock.Text = "";
        }

        private void TerceraTexbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (new List<string>() { "+", "-", "*", "/" }.Contains(this.TerceraTexbox.Text))
            {
                this.CalcularButtom.IsEnabled = true;
            }
            else
            {
                this.CalcularButtom.IsEnabled = false;
            }
        }
    }
}
