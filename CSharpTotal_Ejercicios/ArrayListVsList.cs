using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class ArrayListVsList
    {

        public static void Principal()
        {
            //Inmutable - Limitado a 1 tipo
            int[] puntajes = new int[] { 99, 96, 87, 76 };

            List<int> lista = new List<int> { 1, 2, 3, 4 };

            lista.Add(0);
            lista.Add(32);
            lista.Sort();
            lista.RemoveRange(2, 2);


            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(lista.Contains(4));

            int indice = lista.FindIndex(x => x == 4);
            Console.WriteLine(lista[indice]);

            lista.RemoveAt(indice);

            lista.ForEach(i => Console.WriteLine(i));


            System.Collections.ArrayList arrl = new System.Collections.ArrayList();

            arrl.Add(1);
            arrl.Add("dos");
            arrl.Add("3");
            arrl.Add(new numero { n = 4 });

            foreach (Object o in arrl)
            {
                Console.WriteLine(o);
            }

            Console.Read();
        }
    }

    class numero
    {
        public int n { get; set; }

        public override string ToString()
        {
            return n.ToString();
        }

    }
}
