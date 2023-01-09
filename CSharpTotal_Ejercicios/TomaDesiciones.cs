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
            int numTemperatura = int.Parse(temperatura);

            if (numTemperatura < 20)
            {
                Console.Write("Abrígate!");
            }
            if (numTemperatura == 20)
            {
                Console.WriteLine("Vístete cómodo");
            }
            if (numTemperatura > 20)
            {
                Console.WriteLine("Usa ropa bien liviana");
            }

            Console.Read();
        }
    }
}
