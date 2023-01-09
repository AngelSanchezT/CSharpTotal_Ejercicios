using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class LoopFor
    {
        public static void Principal()
        {
            for (int contador = 1; contador < 20; contador += 2)
            {
                Console.WriteLine(contador + " es impar");
            }
            Console.Read();
        }

    }
}
