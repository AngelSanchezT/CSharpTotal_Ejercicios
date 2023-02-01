using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    internal class Linq1
    {
        public static void Principal()
        {
            int[] numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Impares(numeros);
            Console.Read();
        }

        static void Impares(int[] numeros)
        {
            Console.WriteLine("Cantidad de números impares: ");

            IEnumerable<int> numerosImpares = from numero in numeros where numero % 2 != 0 select numero;

            Console.WriteLine(numerosImpares.Count());

            Console.WriteLine("Los números imapres son: ");

            foreach (int i in numerosImpares)
            {
                Console.WriteLine(i);
            }
        }
    }
}
