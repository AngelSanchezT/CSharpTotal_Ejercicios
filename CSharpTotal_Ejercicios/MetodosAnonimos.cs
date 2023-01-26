using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class MetodosAnonimos
    {
        public delegate string ObtenerDelegadoTexto(string nombre);

        public static void Principal()
        {
            ObtenerDelegadoTexto miDelegado = delegate (string nombre)
            {
                return "Hola, " + nombre;
            };
            Console.WriteLine(miDelegado("Fede"));
            Mostrar(miDelegado);
            Console.ReadKey();
        }

        static void Mostrar(ObtenerDelegadoTexto miDelegado)
        {
            Console.WriteLine(miDelegado("Mundo"));
        }

        public static void DecirHola()
        {
            Console.WriteLine("Hola");
        }
    }
}
