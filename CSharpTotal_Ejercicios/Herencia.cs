using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Herencia
    {
        public static void Principal()
        {
            Publicacion post1 = new Publicacion("Gracias por los saludos de compleaños", true, " Laura Garay");
            Console.WriteLine(post1.ToString());

            PublicacionImagen imagen1 = new PublicacionImagen("Mira mi nuevo perrito", "Laura Garay", "https://imagen.com/perrito", true);
            Console.WriteLine(imagen1.ToString());

            PublicacionImagen imagen2 = new PublicacionImagen("Mira mi nuevo perrito", "Laura Garay", "https://imagen.com/perrito", true);
            Console.WriteLine(imagen1.ToString());

            Publicacion post3 = new Publicacion("Gracias por los saludos de compleaños", true, " Laura Garay");
            Console.WriteLine(post1.ToString());


            Console.Read();
        }
    }
}
