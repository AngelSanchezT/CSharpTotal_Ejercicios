using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq1
{
    internal class LinqConXML
    {
        public static void Principal()
        {
            //Aplicamos la estructura de Estudiante a XML
            string estudiantesXML =
                    @"<Estudiantes>
                        <Estudiante>
                            <Nombre>Mateo</Nombre>
                            <Edad>21</Edad>
                            <Universidad>UNC</Universidad>
                            <Materias>17</Materias>
                        </Estudiante>
                        <Estudiante>
                            <Nombre>Carla</Nombre>
                            <Edad>22</Edad>
                            <Universidad>UNC</Universidad>
                            <Materias>11</Materias>
                        </Estudiante>
                        <Estudiante>
                            <Nombre>Lara</Nombre>
                            <Edad>19</Edad>
                            <Universidad>UBA</Universidad>
                            <Materias>28</Materias>
                        </Estudiante>
                        <Estudiante>
                            <Nombre>Luisa</Nombre>
                            <Edad>23</Edad>
                            <Universidad>UNC</Universidad>
                            <Materias>7</Materias>
                        </Estudiante>
                    </Estudiantes>";

            XDocument estudiantesXdoc = new XDocument();

            estudiantesXdoc = XDocument.Parse(estudiantesXML);

            var estudiantes = from estudiante in estudiantesXdoc.Descendants("Estudiante")
                              select new
                              {
                                  Nombre = estudiante.Element("Nombre").Value,
                                  Edad = estudiante.Element("Edad").Value,
                                  Universidad = estudiante.Element("Universidad").Value,
                                  Materias = estudiante.Element("Materias").Value
                              };

            foreach (var e in estudiantes)
            {
                Console.WriteLine("El estudiante {0} tiene {1} años, y asiste a la universidad {2} y tiene {3} materias aprobadas", e.Nombre, e.Edad, e.Universidad, e.Materias);
            }

            var estudiantesOrdenados = from estudiante in estudiantes
                                       orderby estudiante.Edad
                                       select estudiante;

            foreach (var e in estudiantesOrdenados)
            {
                Console.WriteLine("El estudiante {0} tiene {1} años, y asiste a la universidad {2}", e.Nombre, e.Edad, e.Universidad);
            }



            Console.Read();
        }
    }
}
