using System;

namespace CSharpTotal_Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Por favor, ingresa tu nombre y Presiona Enter");
            nombre = Console.ReadLine();

            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombre.ToLower());
            Console.WriteLine(nombre.Trim());
            Console.WriteLine(nombre.Substring(2));

        }
    }
}
