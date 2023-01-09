using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class DeclaracionIfMejorada
    {
        public static void Principal()
        {
            // condición ? primera_expresión : segunda_expresión ;
            // la condición solo puede ser verdadera o falsa (true / false)
            // el operador condicional es correcto, o sea que es asociativo
            // la expresión a ? b : c ? d : e
            // es evaluada como a ? b : (c ? d : e),
            // no como (a ? b : c) ? d : e

            int temperatura = -5;
            string estadoDelAgua;

            if (temperatura < 0)
                estadoDelAgua = "sólido";
            else
                estadoDelAgua = "líquido";

            Console.WriteLine("El estado del agua es " + estadoDelAgua);

            temperatura += 30;

            estadoDelAgua = temperatura < 0 ? "sólido" : "líquido";

            Console.WriteLine("El estado del agua es " + estadoDelAgua);

            //Desafio

            temperatura += 150;
            estadoDelAgua = temperatura > 99 ? "gaseoso" : temperatura < 0 ? "sólido" : "líquido";

            Console.WriteLine("El estado del agua es " + estadoDelAgua);
            Console.Read();
        }
    }
}
