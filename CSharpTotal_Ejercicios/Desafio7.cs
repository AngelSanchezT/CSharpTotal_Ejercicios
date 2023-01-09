using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    /*
     * Declaración If Mejorada - Desafío de Operador Ternario
     * 
     * Hemos estudiado los operadores ternarios y su uso, así que vamos a plantear un pequeño 
     * desafío al respecto. Vas a crear una pequeña aplicación que tome un valor que represente 
     * la temperatura ingresado por el usuario, y que el verifique si ese valor es un integer 
     * o no.
     * 
     * Si el valor ingresado no es un integer, debe imprimir en la consola 
     * "Esa no es una temperatura válida".
     * 
     * En caso de que el valor ingresado sí sea un integer válido, 
     * entonces debe hacer lo siguiente:
     * 
     * Si el valor de la temperatura ingresada es <=15 debe escribir "Hace mucho frio" 
     * en la consola.
     * 
     * Si el valor de la temperatura ingresada es entre >= 16 y <=28 debe escribir 
     * "Hace un clima agradable" en la consola.
     * 
     * Si el valor de la temperatura ingresada es > 28 debe escribir "Hace mucho calor" 
     * en la consola.
     * 
     * Asegúrate de usar operadores ternarios, y no declaraciones If para chequear 
     * las 3 condiciones. Por supuesto que sí puedes usar una declaración If para verificar 
     * si el valor ingresado es un integer o no.
     */
    internal class Desafio7
    {

        public static void Principal()
        {
            int temperaturaIngresada = 0;
            string mensajeTemperatura = string.Empty;
            string valorIngresado = string.Empty;

            Console.WriteLine("Ingrese la temperatura actual: ");
            valorIngresado = Console.ReadLine();

            bool integerValido = int.TryParse(valorIngresado, out temperaturaIngresada);

            if (integerValido) 
            {
                mensajeTemperatura = temperaturaIngresada <= 15 ?
                    // si es verdadero
                    "Hace mucho frio" :
                    // si es falso
                    temperaturaIngresada >= 16 && temperaturaIngresada <= 28 ?
                    // si es verdadero
                    "Hace un clima agradable" :
                    // si es falso
                    "Hace mucho calor";

                Console.WriteLine(mensajeTemperatura);
            } else
            {
                Console.WriteLine("Esa no es una temperatura válida");
            }

            Console.ReadKey();

        }
    }
}
