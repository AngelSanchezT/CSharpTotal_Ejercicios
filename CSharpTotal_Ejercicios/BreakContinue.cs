using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class BreakContinue
    {
        public static void Principal()
        {
            for (int contador = 0; contador < 10; contador++)
            {

                if (contador % 2 == 0)
                {
                    Console.WriteLine("El próximo es impar");
                    continue;
                }
                Console.WriteLine(contador);
            }
            Console.Read();
        }
    }
}
