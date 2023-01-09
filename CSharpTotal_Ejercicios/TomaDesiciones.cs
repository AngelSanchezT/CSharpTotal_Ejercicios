using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class TomaDesiciones
    {

        public static void Principal()
        {

            Console.WriteLine("Por favor, ingresa la temperatura actual");

            string temperatura = Console.ReadLine();
            int numTemperatura;

            int numero;
            if (int.TryParse(temperatura, out numero))
            {
                numTemperatura = numero;
            }
            else
            {
                numTemperatura = 0;
                Console.WriteLine("El valor ingresado no es válido, se estableció que la temperatura es 0");
            }

            if (numTemperatura < 20)
            {
                Console.Write("Abrígate!");
            }
            else if (numTemperatura == 20)
            {
                Console.WriteLine("Vístete cómodo");
            }
            else if (numTemperatura > 30)
            {
                Console.WriteLine("Hacen 30 grados, ¡qué calor!");
            }
            else
            {
                Console.WriteLine("Usa ropa bien liviana");
            }

            Console.Read();
        }

        public static void CondicionesAnidados()
        {

            bool esAdmin = false;
            bool estaRegistrado = true;
            string nombreDeUsuario = "";

            Console.WriteLine("Por favor, ingrese su nombre de usuario");
            nombreDeUsuario = Console.ReadLine();
            if (estaRegistrado && nombreDeUsuario != "" && nombreDeUsuario.Equals("Admin"))
            {
                Console.WriteLine("Hola usuario registrado");
                Console.WriteLine("Hola " + nombreDeUsuario);
                Console.WriteLine("Hola Admin");
            }

            if (esAdmin || estaRegistrado)
            {
                Console.WriteLine("Estás loguado");
            }


            Console.Read();

        }
    }
}
