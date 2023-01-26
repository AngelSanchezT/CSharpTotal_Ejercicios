using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class ServicioNotificacion
    {
        public void EnArchivoDescargado(object fuente, ArchivoEventArgs e)
        {
            Console.WriteLine("Informamos que el archivo " + e.Archivo.Titulo + " se ha terminado de descargar");
        }
    }
}
