using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    /* Desafío 6 - Declaraciones If 2
     * 
     * Crea una aplicación que maneje los puntajes de un juego imaginario. 
     * Tendrá un puntaje, un puntaje record y un jugador record.
     * 
     * Crea un método que tenga dos parámetros, uno para el puntaje obtenido 
     * y otro para el nombre del jugador.
     * 
     * Cuando se llama a ese método, se debe verificar si el puntaje del jugador 
     * es mayor que la puntuación más alta, si es así, que se escriba en la consola 
     * algo así como"La nueva puntuación más alta es " + puntuación. Y en otra línea 
     * "La puntuación más alta fue lograda por " + nombre del jugador.
     * 
     * Si no fue así, entonces que se escriba algo como 
     * "La puntuación más alta de " + puntuación más alta + " no se ha podido superar, 
     * y aún está en manos de " + jugador record.
     * 
     * Considera qué variables se requieren globalmente y cuáles localmente.
     */

    internal class Desafio6
    {
        static int puntajeRecord = 300;
        static string personaRecord = "Juan";

        public static void Principal()
        {
            RevisarRecord(250, "Mario");
            RevisarRecord(315, "Laura");
            RevisarRecord(350, "Nicolás");
            Console.Read();
        }

        public static void RevisarRecord(int puntaje, string jugador)
        {
            if (puntaje > puntajeRecord)
            {
                personaRecord = jugador;
                puntajeRecord = puntaje;

                PresentarRecordNuevo();
            }
            else
            {
                PresentarRecordVigente();
            }
        }

        public static void PresentarRecordNuevo()
        {
            Console.WriteLine("El nuevo record es " + puntajeRecord);
            Console.WriteLine("Fue logrado por " + personaRecord);
            Console.WriteLine("----------------------------------------");
        }

        public static void PresentarRecordVigente()
        {
            Console.WriteLine("El record vigente de " + puntajeRecord + " logrado por "
                    + personaRecord + " no fue superado");
            Console.WriteLine("----------------------------------------");
        }
    }
}
