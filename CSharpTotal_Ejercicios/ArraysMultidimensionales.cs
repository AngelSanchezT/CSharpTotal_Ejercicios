using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class ArraysMultidimensionales
    {
        public static void Principal() {

            //Declaración de array 2D
            string[,] matriz2D;

            //Declaración de array 3D
            int[,,] matriz3D;

            string[,] array2D = new string[,]
            {
                {"A","B","C" },
                {"D","E","F" },
                {"G","H","I" }
            };

            string[,,] array3D = new string[,,]
                {
                    {
                        {"A","B","C" },
                        {"D","E","F" },
                        {"G","H","I" }
                    },
                    {
                        { "J","K","L" },
                        { "M","N","O" },
                        { "P","Q","R" }
                    },
                    {
                        { "S","T","U" },
                        { "V","W","X" },
                        { "Y","Z","*" }
                    }
                };

            string[,] otroArray2D = new string[3, 2]
                {
                    { "María:", "López"},
                    { "Franco", "Miller"},
                    { "Juana", "Garay"}
                };

            otroArray2D[1, 1] = "Paco";

            // Numero de Dimensiones de Un Array
            int dimension = otroArray2D.Rank;

            int[,] a2D = { { 1, 2 }, { 3, 4 } };


            Console.WriteLine("Las dimensiones del array son {0}", dimension);

            Console.WriteLine(otroArray2D[1, 1]);

            Console.WriteLine("El valor Q es {0}", array3D[1, 2, 1]);
            Console.WriteLine("El valor V es {0}", array3D[2, 1, 0]);
            Console.Read();
        }
    }
}
