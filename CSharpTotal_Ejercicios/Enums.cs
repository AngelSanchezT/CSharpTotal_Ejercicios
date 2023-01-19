using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Enums
    {
        enum Dia { Lu, Ma, Mi, Ju, Vi, Sa, Do };

        enum Mes { Ene = 1, Feb, Mar, Abr, May, Jun, Jul = 12, Ago, Sep, Oct, Nov, Dic };
        public static void Principal() {
            Dia viernes = Dia.Vi;
            Dia domingo = Dia.Do;
            Dia a = Dia.Vi;
            Console.WriteLine(Dia.Lu);

            Console.WriteLine((int)Dia.Lu);

            Console.WriteLine(viernes == a);

            Console.WriteLine((int)Mes.Ago);

            Console.Read();
        }
    }
}
