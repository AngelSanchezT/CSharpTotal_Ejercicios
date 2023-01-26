using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class ServicioDesempacar
    {
        public void EnArchivoDescargado(object fuente, ArchivoEventArgs e)
        {
            Console.WriteLine("ServicioDesempacar: desempacando el archivo " + e.Archivo.Titulo);
        }
    }
}
