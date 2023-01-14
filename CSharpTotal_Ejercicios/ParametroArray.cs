using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class ParametroArray
    {
        public static void Principal()
        {
            int[] calificaciones = new int[] { 8, 7, 9, 3, 10, 5, 4, 7 };
            double promedioResultado = ObtenerPromedio(calificaciones);

            int[] saldos = { 1100, 200, 500, -100 };

            Credito(saldos);

            foreach (int y in saldos)
            {
                Console.WriteLine(y);
            }
            Console.Read();

            foreach (int nota in calificaciones)
            {
                Console.WriteLine("{0}", nota);
            }

            Console.WriteLine("El promedio es {0}", promedioResultado);
            Console.Read();


        }

        static void Credito(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] += 200;
            }
        }



        static double ObtenerPromedio(int[] arrayDePuntajes)
        {
            int cantidad = arrayDePuntajes.Length;
            double promedio;
            int suma = 0;

            for (int i = 0; i < cantidad; i++)
            {
                suma += arrayDePuntajes[i];
            }

            promedio = (double)suma / cantidad;

            return promedio;

        }
    }
}
