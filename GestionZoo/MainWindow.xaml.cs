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
using System.Data.SqlClient;
using System.Data;

namespace GestionZoo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();


            string connectionString = ConfigurationManager.ConnectionStrings["GestionZoo.Properties.Settings.EscDirectaDBConnectionString"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);

            MuestraZoos();
            MuestraAnimales();
        }


        private void MuestraZoos()
        {

            try
            {
                string consulta = "select * from Zoo";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTabla = new DataTable();
                    sqlDataAdapter.Fill(zooTabla);

                    ListaZoos.DisplayMemberPath = "Ubicación";
                    ListaZoos.SelectedValuePath = "Id";
                    ListaZoos.ItemsSource = zooTabla.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            
        }

        private void MuestraAnimales()
        {

            try
            {
                string consulta = "select * from Animal";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable animalTabla = new DataTable();
                    sqlDataAdapter.Fill(animalTabla);

                    ListaAnimales.DisplayMemberPath = "Nombre";
                    ListaAnimales.SelectedValuePath = "Id";
                    ListaAnimales.ItemsSource = animalTabla.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }


        private void MuestraAnimalesAsociados()
        {

            try
            {
                string consulta = "select * from Animal a Inner Join AnimalZoo az on a.Id = az.AnimalId where az.ZooId = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", ListaZoos.SelectedValue);

                    DataTable AnimalTabla = new DataTable();
                    sqlDataAdapter.Fill(AnimalTabla);

                    ListaAnimalesAsociados.DisplayMemberPath = "Nombre";
                    ListaAnimalesAsociados.SelectedValuePath = "Id";
                    ListaAnimalesAsociados.ItemsSource = AnimalTabla.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
             

        }

        private void ListaZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MuestraAnimalesAsociados();
        }
    }
}
