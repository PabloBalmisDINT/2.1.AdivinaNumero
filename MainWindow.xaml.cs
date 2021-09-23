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

namespace _2._1.AdivinaNumero
{
    public partial class MainWindow : Window
    {
        private int numero;
        public MainWindow()
        {
            InitializeComponent();

            Random random = new Random();
            numero = random.Next(0,100);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(int.Parse(IntentoTextBox.Text) == numero)
            {
                RespuestaTextBlock.Text = "Has acertado";
            }
            else if(int.Parse(IntentoTextBox.Text) > numero)
            {
                RespuestaTextBlock.Text = "Te has pasado";
            }
            else
            {
                RespuestaTextBlock.Text = "Te has quedado corto";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            numero = random.Next(0, 100);
            RespuestaTextBlock.Text = "";
            IntentoTextBox.Text = "";
        }
    }
}
