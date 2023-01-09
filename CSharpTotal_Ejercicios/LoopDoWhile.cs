using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class LoopDoWhile
    {
        public static void Principal()
        {
            int largoDeTexto = 0;
            string textoCompleto = "";
            do
            {
                Console.WriteLine("Por favor, ingresa el nombre de un amigo");
                string nombreAmigo = Console.ReadLine();
                int largoActual = nombreAmigo.Length;
                largoDeTexto += largoActual;
                textoCompleto += nombreAmigo;
            } while (largoDeTexto < 20);
            Console.WriteLine("Gracias, eso es todo " + textoCompleto);
            Console.Read();
        }
    }
}
