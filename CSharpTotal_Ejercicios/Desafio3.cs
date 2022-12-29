using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Desafio3
    {
        /*
         * Desafío - Tipos de Datos y Variables
        Ahora que sabes cómo declarar e inicializar variables, avanza y crea una variable para cada uno
        de los tipos de datos primitivos (puede encontrar la lista de aquí). No es necesario que hagas el
        tipo de dato llamado Object.

        También inicializa cada variable con un valor cualquiera. Luego crea dos valores de tipo string. 
        El primero debería decir "Yo controlo el texto". El segundo debe ser un número entero.

        Luego usa el método Parse para convertir esa cadena en un entero.

        Agrega a cada uno una salida para que se escríba en la consola (WriteLine). Siéntete libre de nombrar 
        tus variables como quieras, pero ten en cuenta que los nombres de las variables de mi ejemplo 
        serán diferentes a los tuyos.

        https://learn.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2008/ms228360(v=vs.90)?redirectedfrom=MSDN
         
        */
        public static void Principal() {
            byte miByte = 25;
            Console.WriteLine(miByte);
            sbyte miSbyte = 15;
            Console.WriteLine(miSbyte);
            int miInt = 12318925;
            Console.WriteLine(miInt);
            uint miUint = 123091;
            Console.WriteLine(miUint);
            short miShort = -32768;
            Console.WriteLine(miShort);
            ushort miUshort = 65535;
            Console.WriteLine(miUshort);
            float miFloat = -31.1289f;
            Console.WriteLine(miFloat);
            double miDouble = -12.1231250;
            Console.WriteLine(miDouble);
            char miChar = 'A';
            Console.WriteLine(miChar);
            bool miBool = true;
            Console.WriteLine(miBool);
            string miTexto = "Yo controlo el texto";
            Console.WriteLine(miTexto);
            string numTexto = "15";

            int miNumeroDesdeTexto = int.Parse(numTexto);
            Console.WriteLine(miNumeroDesdeTexto);
            Console.Read();
        }
    }
}
