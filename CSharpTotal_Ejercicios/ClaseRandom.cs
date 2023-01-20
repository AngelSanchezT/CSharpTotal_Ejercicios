using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class ClaseRandom
    {
        public static void Principal() {
            /*Random dado = new Random();
            int numCara;

            for (int i = 0; i < 10; i++)
            {
                numCara = dado.Next(1, 7);
                Console.WriteLine(numCara);
            }*/

            Console.WriteLine("Por favor, haz una pregunta que se responda por sí o por no");
            Console.ReadLine();

            Random RuedaFortuna = new Random();
            int numRespuesta;
            numRespuesta = RuedaFortuna.Next(1, 4);

            if (numRespuesta == 1)
            {
                Console.WriteLine("Sí");
            }
            else if (numRespuesta == 2)
            {
                Console.WriteLine("Quizás");
            }
            else
            {
                Console.WriteLine("No");
            }


            Console.Read();
        }
    }
}
