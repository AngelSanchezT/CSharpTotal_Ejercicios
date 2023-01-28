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

namespace WPF_06
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int ColorDeOjos
        {
            get { return (int)GetValue(ColorDeOjosProperty); }
            set { SetValue(ColorDeOjosProperty, value); }
        }

        public static readonly DependencyProperty ColorDeOjosProperty =
            DependencyProperty.Register("ColorDeOjos", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
