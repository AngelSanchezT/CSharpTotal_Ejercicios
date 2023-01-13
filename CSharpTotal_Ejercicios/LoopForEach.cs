using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class LoopForEach
    {
        public static void Principal() {

            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            /*
            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("El valor del indice {0} es {1}", j, nums[j]);
            }
            */

            foreach (int k in nums)
            {
                Console.WriteLine("El valor del índice {0} es {1}", k, nums[k]);
            }

            string[] amigos = { "Germán", "Fede", "Julieta", "Lucio", "Fernando", "Ana" };

            foreach (string nombre in amigos)
            {
                Console.WriteLine("Hola, {0}, te quiero mucho", nombre);
            }

            Console.Read();
        }

    }
}
