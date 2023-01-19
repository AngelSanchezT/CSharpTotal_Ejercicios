using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Structs
    {
        public struct Juego
        {
            public string nombre;
            public string desarrollador;

            public void Mostrar()
            {
                Console.WriteLine(" El nombre del juego es {0}", nombre);
                Console.WriteLine("El desarrollador es {0}", desarrollador);
            }

            public Juego(string nombre, string desarrollador)
            {
                this.nombre = nombre;
                this.desarrollador = desarrollador;
            }

        }

        public static void Principal()
        {
            Juego juego1;



            juego1.nombre = "Casa Zombie";

            juego1.desarrollador = "Nintendo";

            juego1.Mostrar();

        }




    }
}
