using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    internal class LinqObjetosYOperadoresConsulta
    {
        public static void Principal()
        {
            GestionUniversidad ge = new GestionUniversidad();
            ge.ObtenerEstudiantesMasculinos();
            ge.ObtenerEstudiantesFemeninos();
            ge.ObtenerEstudiantesNoBinarios();
            ge.OrdenarEstudiantesPorEdad();
            ge.MostrarEstudiantesUBA();

            /*string ingreso = Console.ReadLine();

            try
            {
                int ingresoComInt = Convert.ToInt32(ingreso);

                ge.MostrarEstudiantesDeEsaUniversidad(ingresoComInt);
            }
            catch (Exception)
            {
                Console.WriteLine("Valor equivocado");
            }*/

            int[] unosInts = { 30, 12, 4, 3, 19 };
            IEnumerable<int> intsOrdenados = from i in unosInts orderby i select i;

            IEnumerable<int> intsAlReves = intsOrdenados.Reverse();
            foreach (int i in intsAlReves)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> otrosIntAlReves = from i in unosInts orderby i descending select i;
            foreach (int i in otrosIntAlReves)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }

    class GestionUniversidad
    {
        public List<Universidad> universidades;
        public List<Estudiante> estudiantes;

        //Constructor
        public GestionUniversidad()
        {
            universidades = new List<Universidad>();
            estudiantes = new List<Estudiante>();

            //Agregar Universidades
            universidades.Add(new Universidad { Id = 1, Nombre = "UNC" });
            universidades.Add(new Universidad { Id = 2, Nombre = "UBA" });

            //Agregar Estudiantes
            estudiantes.Add(new Estudiante { Id = 1, Nombre = "Carla", Genero = "femenino", Edad = 19, UniversidadId = 1 });
            estudiantes.Add(new Estudiante { Id = 2, Nombre = "Mateo", Genero = "masculino", Edad = 21, UniversidadId = 1 });
            estudiantes.Add(new Estudiante { Id = 3, Nombre = "Franco", Genero = "masculino", Edad = 22, UniversidadId = 2 });
            estudiantes.Add(new Estudiante { Id = 4, Nombre = "Lara", Genero = "femenino", Edad = 19, UniversidadId = 2 });
            estudiantes.Add(new Estudiante { Id = 5, Nombre = "Javier", Genero = "no binario", Edad = 25, UniversidadId = 2 });
            estudiantes.Add(new Estudiante { Id = 6, Nombre = "Lorena", Genero = "femenino", Edad = 22, UniversidadId = 2 });

        }

        public void ObtenerEstudiantesMasculinos()
        {
            IEnumerable<Estudiante> estudiantesMasculinos = from estudiante in estudiantes where estudiante.Genero == "masculino" select estudiante;

            Console.WriteLine("Estudiantes Masculinos: ");
            foreach (Estudiante estudiante in estudiantesMasculinos)
            {
                estudiante.MostrarEstudiante();
            }
        }

        public void ObtenerEstudiantesFemeninos()
        {
            IEnumerable<Estudiante> estudiantesFemeninos = from estudiante in estudiantes where estudiante.Genero == "femenino" select estudiante;

            Console.WriteLine("Estudiantes femeninos: ");
            foreach (Estudiante estudiante in estudiantesFemeninos)
            {
                estudiante.MostrarEstudiante();
            }
        }

        public void ObtenerEstudiantesNoBinarios()
        {
            IEnumerable<Estudiante> estudiantesNoBinarios = from estudiante in estudiantes where estudiante.Genero == "no binario" select estudiante;

            Console.WriteLine("Estudiantes No Binarios: ");
            foreach (Estudiante estudiante in estudiantesNoBinarios)
            {
                estudiante.MostrarEstudiante();
            }
        }

        public void OrdenarEstudiantesPorEdad()
        {
            var estudiantesOrdenados = from estudiante in estudiantes orderby estudiante.Edad select estudiante;
            Console.WriteLine("Oestudiantes ordenados según edad: ");
            foreach (Estudiante e in estudiantesOrdenados)
            {
                e.MostrarEstudiante();
            }
        }

        public void MostrarEstudiantesUBA()
        {
            IEnumerable<Estudiante> estudiantesUBA = from estudiante in estudiantes
                                                     join universidad in universidades on estudiante.UniversidadId
                                                     equals universidad.Id
                                                     where universidad.Nombre == "UBA"
                                                     select estudiante;

            Console.WriteLine("Estudiantes de UBA");
            foreach (Estudiante e in estudiantesUBA)
            {
                e.MostrarEstudiante();
            }
        }

        public void MostrarEstudiantesDeEsaUniversidad(int Id)
        {
            IEnumerable<Estudiante> esosEstudiantes = from estudiante in estudiantes
                                                      join universidad in universidades on estudiante.UniversidadId
                                                      equals universidad.Id
                                                      where universidad.Id == Id
                                                      select estudiante;

            Console.WriteLine("Estudiantes de Universidad {0}", Id);
            foreach (Estudiante e in esosEstudiantes)
            {
                e.MostrarEstudiante();
            }
        }

    }

    class Universidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void MostrarUniversidad()
        {
            Console.WriteLine("Universidad {0}, tiene el Id {1}", Nombre, Id);
        }
    }

    class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }

        public int UniversidadId { get; set; }

        public void MostrarEstudiante()
        {
            Console.WriteLine("Estudiante: {0}, tiene el Id {1}, edad {2}, de género {3} asiste a universidad {4}", Nombre, Id, Edad, Genero, UniversidadId);


        }
    }
}
