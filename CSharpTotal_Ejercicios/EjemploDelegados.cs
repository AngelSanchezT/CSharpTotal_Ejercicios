using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class EjemploDelegados
    {
        public delegate double HacerCalculo(double x, double y);

        public static double Suma(double a, double b)
        {
            Console.WriteLine("a+b es: " + (a + b));
            return a + b;
        }

        public static double Division(double a, double b)
        {
            Console.WriteLine("a/b es: " + (a / b));
            return a / b;
        }

        public static double Resta(double a, double b)
        {
            Console.WriteLine("a-b es: " + (a - b));
            return a - b;
        }

        public static void Principal()
        {
            HacerCalculo miSuma = Suma;
            //miSuma(5.0, 5.0);
            HacerCalculo miDivision = Division;
            //miDivision(5.0, 5.0);
            HacerCalculo calculoMultiple = miSuma + miDivision;
            calculoMultiple += Resta;
            calculoMultiple -= miSuma;
            calculoMultiple(3.2, 3.2);

            Console.ReadKey();
        }

    }
}
