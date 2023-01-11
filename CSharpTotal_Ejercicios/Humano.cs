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
        
        // Miembro constructor
        public Humano(string primerNombre, string apellido, string colorOjos, int edad)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
            this.edad = edad;
        }

        // Miembro Metodo
        public void presentarme()
        {
            if (edad == 1)
                Console.WriteLine("Hola, soy {0} {1} y tengo {2} año de edad. Mi color de ojos es {3}"
                    , primerNombre, apellido, edad, colorOjos);
            else
                Console.WriteLine("Hola, soy {0} {1} y tengo {2} años de edad. Mi color de ojos es {3}"
                , primerNombre, apellido, edad, colorOjos);
        }

    }
}
