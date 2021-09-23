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
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();

        int numeroAdivinar;
        public MainWindow()
        {
            InitializeComponent();
            numeroAdivinar = rnd.Next(0, 101);
        }
        private void Reiniciar(object sender, RoutedEventArgs e)
        {
            numeroAdivinar = rnd.Next(0, 101);

            NumeroUsuarioTextBox.Text = "";
            TextoRespuestaTextBlock.Text = "";
        }

        private void Comprobar(object sender, RoutedEventArgs e)
        {
            if(int.Parse(NumeroUsuarioTextBox.Text) == numeroAdivinar)
            {
                TextoRespuestaTextBlock.Text = "Has acertado";
            }
            else if(int.Parse(NumeroUsuarioTextBox.Text) > numeroAdivinar)
            {
                TextoRespuestaTextBlock.Text = "Te has pasado";
            }
            else
            {
                TextoRespuestaTextBlock.Text = "Te has quedado corto";
            }
        }
    }
}
