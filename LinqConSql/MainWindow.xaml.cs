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
using System.Configuration;

namespace LinqConSql
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString = ConfigurationManager.ConnectionStrings["LinqConSql.Properties.Settings.EscDirectaDBConnectionString"].ConnectionString;

        public MainWindow()
        {
            DataClasses1DataContext dataContext;
            dataContext = new DataClasses1DataContext(connectionString);

            InitializeComponent();
        }
    }
}
