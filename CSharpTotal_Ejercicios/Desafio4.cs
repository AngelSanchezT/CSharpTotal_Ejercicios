using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    /**
     * Desafío - Métodos
     * En este desafío, profundizarás su comprensión de los métodos. 
     * La consigna es que crees tres variables con los nombres de tus amigos. 
     * Luego, crea un Método llamado "SaludarAmigo" que escriba algo como: 
     * "¡Hola (nombre del amigo), que tengas un buen día!" en la consola. 
     * Donde dice "nombre del amigo" debe reemplazarse con el Nombre que hayas 
     * puesto tras el argumento dado al Método cuando ha sido llamado. 
     * Por lo tanto, el método necesitará un parámetro (decide tu qué tipo 
     * de datos es el mejor).
     */
    internal class Desafio4
    {
        public static void Principal() {
            string amigo1 = "Jairo";
            string amigo2 = "Ricardo";
            string amigo3 = "Camilo";

            Console.WriteLine("Forma 1: ");

            SaludarAmigo(amigo1);
            SaludarAmigo(amigo2);
            SaludarAmigo(amigo3);

            Console.WriteLine("\nForma 2: ");

            SaludarAmigos(amigo1, amigo2, amigo3);


            Console.Read();
        }

        public static void SaludarAmigo(string amigo) { 
            Console.WriteLine($"¡Hola {amigo}, que tengas un buen día!");
        }

        public static void SaludarAmigos(string amigo1, string amigo2, string amigo3)
        {
            Console.WriteLine($"¡Hola {amigo1}, que tengas un buen día!");
            Console.WriteLine($"¡Hola {amigo2}, que tengas un buen día!");
            Console.WriteLine($"¡Hola {amigo3}, que tengas un buen día!");
        }
    }
}
