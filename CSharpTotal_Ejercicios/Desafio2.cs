using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Desafio2
    {
        /*
         Aplicación 1

        Esta aplicación le pide al usuario:

        En la primera línea, que ingrese un string del tipo "Ingrese un texto aquí:".

        En la segunda línea, debe pedirle un carácter que quiere que busque en el texto (string) que ha ingresado en la primera línea. Se puede pedir por ejemplo así: "Ingrese la letra buscada:"

        En la tercera línea, debe escribir el índice de la primera aparición del carácter buscado en el string.
         */
        public static void Desafio2_1()
        {
            Console.Write("Ingrese un texto aquí:");
            string texto = Console.ReadLine();
            Console.Write("Ingrese la letra buscada:");
            char palabraBuscada = Console.ReadLine()[0];
            int buscarIndice = texto.IndexOf(palabraBuscada);
            Console.WriteLine($"La palabra buscada {palabraBuscada} esta en la posición: {buscarIndice}");
            Console.ReadKey();

        }

        /**
         * Aplicación 2

            Y ahora un ejercicio de concatenación:

            Crea un código que haga que la consola solicite ingresar el nombre. Una vez que el usuario escribe el nombre y presiona Enter, debe solicitar ingresar el apellido.

            Luego debería mostrar su nombre completo impreso en una sola línea. Por ejemplo en mi caso mostraría "Federico Garay". Procura almacenar el nombre completo en una variable antes de mostrarla.
        */
        public static void Desafio2_2()
        {
            Console.Write("Por favor ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Por favor ingrese su apellido: ");
            string apellido = Console.ReadLine();
            string nombreCompleto = String.Concat(nombre, " ", apellido);
            Console.WriteLine($"{nombreCompleto}");
            Console.ReadKey();
        }
    }
}
