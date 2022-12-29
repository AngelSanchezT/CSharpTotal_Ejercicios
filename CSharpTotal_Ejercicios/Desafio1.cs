using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Desafio1
    {
        /**
         * El programa debe escribir en la consola:

            En la primera línea, ese string en mayúsculas

            En la segunda línea el mismo string en minúsculas

            En la tercera línea, escribe en la consola el string sin espacios en blanco al final o al principio, (por ejemplo si se ingresa " Federico ", debería escribirse en la consola "Federico".

            Y en la última línea, debe escribir el Substring del string ingresado en la consola.
         */
        public static void Principal() {
            string nombre;
            Console.Write("Por favor, ingresa tu nombre y Presiona Enter: ");
            nombre = Console.ReadLine();

            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombre.ToLower());
            Console.WriteLine(nombre.Trim());
            Console.WriteLine(nombre.Substring(2));
            Console.ReadKey();
        }
    }
}
