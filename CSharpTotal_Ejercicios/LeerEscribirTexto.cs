using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class LeerEscribirTexto
    {
        public static void Principal()
        {
            //Metodo 1
            string[] lineas = { "Primero 250", "Segundo 242", "Tercero 240" };

            File.WriteAllLines(@"C:\Users\Win10\Desktop\Textos\Puntajes.txt", lineas);


            /*
            //Metodo 2
            Console.WriteLine("Por favor ingrese el nombre del archivo");
            string nombreArchivo = Console.ReadLine();
            Console.WriteLine("Por favor ingrese el contenido del archivo");
            string texto = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Win10\Desktop\Textos\" + nombreArchivo + ".txt", texto);
            */

            //Metodo 3
            using (StreamWriter archivo = new StreamWriter(@"C:\Users\Win10\Desktop\Textos\miTexto2.txt"))
            {
                foreach (string linea in lineas)
                {
                    if (linea.Contains("4"))
                    {
                        archivo.WriteLine(linea);
                    }
                }
            }

            using (StreamWriter archivo = new StreamWriter(@"C:\Users\Win10\Desktop\Textos\miTexto2.txt", true))
            {
                archivo.WriteLine("Linea adicional");
            }


            /*//Leer texto completo
            string texto = System.IO.File.ReadAllText(@"C:\Users\Win10\Desktop\Textos\LeerArchivoTexto.txt");
            Console.WriteLine("El archivo contiene el siguiente texto: {0}", texto);

            //Leear de a líneas
            string[] lineas = System.IO.File.ReadAllLines(@"C:\Users\Win10\Desktop\Textos\LeerArchivoTexto.txt");
            foreach(string linea in lineas)
            {
                Console.WriteLine("\t" + linea);
            }
            */
            Console.Read();
        }
    }
}
