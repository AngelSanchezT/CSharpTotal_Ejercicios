using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Nulabilidad
    {
        public static void Principal()
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14157;

            bool? valor = new bool?();

            Console.WriteLine("Nuestros valors son: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("Nuestro booleano es: {0}", valor);

            bool? esHombre = null;

            if (esHombre == true)
            {
                Console.WriteLine("El usuario es hombre");

            }
            else if (esHombre == false)
            {
                Console.WriteLine("El usuario es mujer");
            }
            else
            {
                Console.WriteLine("No se especificó género");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if (num6 == null)
            {
                num8 = 0.00;
            }
            else
            {
                num8 = (double)num6;
            }

            Console.WriteLine("El valor de num8 es {0}", num8);

            num8 = num6 ?? 8.53;
            Console.WriteLine("El valor de num8 es {0}", num8);

            num8 = num7 ?? 8.53;
            Console.WriteLine("El valor de num8 es {0}", num8);

            Console.Read();

        }
    }
}
