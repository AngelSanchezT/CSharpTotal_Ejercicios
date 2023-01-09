using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class CondisionSwitch
    {
        public static void Principal()
        {
            int autos = 1;

            switch (autos)
            {
                case 0:
                    Console.WriteLine("Usted no paga impuestos");
                    break;
                case 1:
                    Console.WriteLine("Usted paga $15");
                    break;
                case 2:
                    Console.WriteLine("Usted paga $30");
                    break;
                default:
                    Console.WriteLine("Usted paga $15 dolares por auto");
                    break;
            }

            if (autos == 0)
            {
                Console.WriteLine("Usted no paga impuestos");
            }
            else if (autos == 1)
            {
                Console.WriteLine("Usted paga $15");
            }
            else if (autos == 2)
            {
                Console.WriteLine("Usted paga $30");
            }
            else
            {
                Console.WriteLine("Usted paga $15 dolares por auto");
            }

            string piedraPapelTijera = "Tijera";

            switch (piedraPapelTijera)
            {
                case "Piedra":
                    Console.WriteLine("Piedra mata a tijera");
                    break;
                case "Papel":
                    Console.WriteLine("Papel mata a piedra");
                    break;
                case "Tijera":
                    Console.WriteLine("Tijera mata a papel");
                    break;
                default:
                    Console.WriteLine("Ese elemento no forma parte del juego");
                    break;
            }

            Console.Read();
        }

    }
}
