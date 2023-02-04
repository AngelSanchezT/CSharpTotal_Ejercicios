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
        DataClasses1DataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqConSql.Properties.Settings.EscDirectaDBConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(connectionString);

            //AgregarUniversidades();
            AgregarEstudiantes();

        }

        public void AgregarUniversidades()
        {
            dataContext.ExecuteCommand("delete from Universidad");

            Universidad UNC = new Universidad();
            UNC.Nombre = "UNC";

            dataContext.Universidad.InsertOnSubmit(UNC);

            Universidad UBA = new Universidad();

            UBA.Nombre = "UBA";
            dataContext.Universidad.InsertOnSubmit(UBA);

            dataContext.SubmitChanges();

            DataGridPrincipal.ItemsSource = dataContext.Universidad;
        }

        public void AgregarEstudiantes()
        {
            Universidad UNC = dataContext.Universidad.First(un => un.Nombre.Equals("UNC"));
            Universidad UBA = dataContext.Universidad.First(un => un.Nombre.Equals("UBA"));

            List<Estudiante> estudiantes = new List<Estudiante>();
            estudiantes.Add(new Estudiante { Nombre = "Carla", Genero = "Femenino", UniversidadId = UNC.Id });
            estudiantes.Add(new Estudiante { Nombre = "Mateo", Genero = "Masculino", Universidad = UNC });
            estudiantes.Add(new Estudiante { Nombre = "Laura", Genero = "Femenino", Universidad = UBA });
            estudiantes.Add(new Estudiante { Nombre = "Juan", Genero = "Trans-genero", Universidad = UBA });

            dataContext.Estudiante.InsertAllOnSubmit(estudiantes);
            dataContext.SubmitChanges();

            DataGridPrincipal.ItemsSource = dataContext.Estudiante;
        }

    }
}
