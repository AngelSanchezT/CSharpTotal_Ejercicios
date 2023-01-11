using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    /*
     * Desafío - Loop Promedio
     * Imagina que eres un desarrollador y obtienes un trabajo en el que necesitas crear un programa
     * para un maestro. Él necesita un programa escrito en C# que calcule el puntaje promedio de un 
     * estudiante. Por lo tanto, quiere poder ingresar cada puntaje de ese alumno individualmente. 
     * Cuando termine de cargar todas las calificaciones del alumno, debe escribir la palabra "fin" 
     * para que el programa le devuelva el promedio que ese alumno ha logrado.
     * 
     * Por lo tanto, la herramienta debe verificar si la entrada es un número y agregarlo a la suma.
     * Finalmente, una vez que haya terminado de ingresar puntajes, el programa debe escribir en 
     * la consola cuál es el puntaje promedio.
     * 
     * Los números ingresados solo pueden estar entre 1 y 10. 
     * 
     * Asegúrate de que el programa no se bloquee si el maestro ingresa un valor incorrecto.
     * 
     * Testea tu programa para asegurarte de que no tenga errores
     */
    internal class Desafío8
    {
        public static void Principal() {
            string ingreso = "0";
            int contador = 0;
            int total = 0;
            int numeroActual = 0;

            while (ingreso != "fin")
            {
                Console.WriteLine("El número actual es {0}", numeroActual);
                Console.WriteLine("La cantidad de calificaciones ingresadas es de {0}", contador);
                Console.WriteLine("Cuando desee finalizar la carga de datos, escriba 'fin'");
                Console.WriteLine("Por favor ingrese la siguiente calificación");

                ingreso = Console.ReadLine();

                if (ingreso.Equals("fin"))
                {
                    Console.WriteLine("----------------------------------------");
                    double promedio = (double)total / (double)contador;
                    Console.WriteLine("El promedio obtenido por el alumno fue {0}", promedio);
                }

                if (int.TryParse(ingreso, out numeroActual) && numeroActual > 0 && numeroActual < 11)
                {
                    total += numeroActual;
                }
                else
                {
                    if (!(ingreso.Equals("fin")))
                    {
                        Console.WriteLine("Por favor ingrese un número entre 1 y 10");

                    }
                    continue;
                }
                contador++;

            }
            Console.Read();

        }
    }
}
