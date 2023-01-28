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

namespace WPF_11
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

        private void cbTodosHaCambiado (object sender, RoutedEventArgs e)
        {
            bool nuevoValor = (cbTodos.IsChecked == true);
            cbChile.IsChecked = nuevoValor;
            cbHongos.IsChecked = nuevoValor;
            cbMuzzarella.IsChecked = nuevoValor;
        }

        private void cbSimpleHaCambiado (object sender, RoutedEventArgs e)
        {
            cbTodos.IsChecked = null;
            if((cbChile.IsChecked == true) && (cbHongos.IsChecked == true) && (cbMuzzarella.IsChecked == true))
            {
                cbTodos.IsChecked = true;
            }
            if ((cbChile.IsChecked == false) && (cbHongos.IsChecked == false) && (cbMuzzarella.IsChecked == false))
            {
                cbTodos.IsChecked = false;
            }
        }
    }
}
