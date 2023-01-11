using System;

namespace CSharpTotal_Ejercicios
{
    internal class Program
    {

        // TODO: Crear Carpetas por Sección del CURSO con sus ejemplos, teoria y desafios.
        // TODO: Menu de Ejecución de Proyectos.
        // TODO: Documentar las clases
        // TODO: Documentar en el Readme el indice.
        static void Main(string[] args)
        {
            // Desafio1.Principal();
            // Desafio2.Desafio2_1();
            // Desafio2.Desafio2_2();
            // Desafio3.Principal();

            // Desafio4.Principal();
            // Operadores.Principal();

            // ## Sección 4. Toma Desiciones
            // TomaDesiciones.Principal();
            // TomaDesiciones.CondicionesAnidados();
            // Desafio5.Principal();
            // CondisionSwitch.Principal();
            // Desafio6.Principal();
            // Desafio7.Principal();

            // ## Sección 5. Loop
            // LoopFor.Principal();
            // LoopDoWhile.Principal();
            // LoopWhile.Principal();
            // BreakContinue.Principal();
            // Desafío8.Principal();

            // ## Sección 6: Clases y Objetos
            // Crea un Objeto de una clase.
            // Una instancia de humano
            Humano luis = new Humano("Luis", "Garay", "Marrón", 42);
            Humano ana = new Humano("Ana", "Maina", "Verde", 1);

            // Llama a un metodo de la clase
            luis.presentarme();
            ana.presentarme();

            Console.Read();




        }
    }
}
