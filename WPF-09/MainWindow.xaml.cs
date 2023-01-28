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

namespace WPF_09
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Juego> juegos = new List<Juego>();
            juegos.Add(new Juego() { Eq1 = "Barcelona", Eq2 = "Real Madrid", Puntaje1 = 3, Puntaje2 = 2, Progreso = 85 });
            juegos.Add(new Juego() { Eq1 = "PSG", Eq2 = "Bayern Munich", Puntaje1 = 3, Puntaje2 = 5, Progreso = 55 });
            juegos.Add(new Juego() { Eq1 = "BVB Dormundt", Eq2 = "As Roma", Puntaje1 = 0, Puntaje2 = 1, Progreso = 25 });
            juegos.Add(new Juego() { Eq1 = "Man United", Eq2 = "Ajax", Puntaje1 = 1, Puntaje2 = 1, Progreso = 15 });

            lbJuego.ItemsSource = juegos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbJuego.SelectedItem != null)
                {
                MessageBox.Show("Juego Seleccionado: " + (lbJuego.SelectedItem as Juego).Eq1 + " " +
                    (lbJuego.SelectedItem as Juego).Puntaje1 + " " + (lbJuego.SelectedItem as Juego).Eq2 + " " +
                    (lbJuego.SelectedItem as Juego).Puntaje2);
                }
        }
    }

    public class Juego
    {
        public int Puntaje1 { get; set; }
        public int Puntaje2 { get; set; }
        public string Eq1 { get; set; }
        public string Eq2 { get; set; }
        public int Progreso { get; set; }
    }
}
