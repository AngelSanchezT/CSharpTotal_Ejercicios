using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Humano
    {
        // Miembro Variable
        private string primerNombre;
        private string apellido;
        private string colorOjos;
        private int edad;

        // Constructor por defecto
        public Humano()
        {
            Console.WriteLine("Constructor llamado. Objeto creado");
        }

        // Miembro constructor parametrizado
        public Humano(string primerNombre, string apellido, string colorOjos, int edad)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
            this.edad = edad;
        }

        public Humano(string primerNombre, string apellido, string colorOjos)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
        }

        public Humano(string primerNombre, string apellido)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
        }

        public Humano(string primerNombre)
        {
            this.primerNombre = primerNombre;
        }

        // Miembro Metodo
        public void presentarme()
        {
            if (edad != 0 && primerNombre != null && apellido != null && colorOjos != null)
            { 
                if (edad == 1)
                    Console.WriteLine("Hola, soy {0} {1} y tengo {2} año de edad. Mi color de ojos es {3}"
                        , primerNombre, apellido, edad, colorOjos);
                else
                    Console.WriteLine("Hola, soy {0} {1} y tengo {2} años de edad. Mi color de ojos es {3}"
                    , primerNombre, apellido, edad, colorOjos);

            } 
            else if (primerNombre != null && apellido != null && colorOjos != null)
            { 
                Console.WriteLine("Hola, soy {0} {1}. Mi color de ojos es {2}"
                , primerNombre, apellido, colorOjos);
            }
            else if (primerNombre != null && apellido != null)
            { 
                Console.WriteLine("Hola, soy {0} {1}"
                , primerNombre, apellido);
            }
            else if (primerNombre != null)
            { 
                Console.WriteLine("Hola, soy {0}"
                , primerNombre);
            }
        }

    }
}
