using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpTotal_Ejercicios
{
    internal class ExpresionesRegulares
    {
        public static void Principal()
        {
            string patron = @"Hola";
            string texto = "Hola, mi numero telefonico es 123456";
            Regex regex = new Regex(patron);

            MatchCollection aciertos = regex.Matches(texto);

            Console.WriteLine("{0} aciertos encontrados:\n {1}", aciertos.Count, texto);

            foreach (Match acierto in aciertos)
            {
                GroupCollection grupo = acierto.Groups;
                Console.WriteLine("{0} fue encontrado en {1}", grupo[0].Value, grupo[0].Index);

                Console.ReadLine();
            }
        }
    }
}
