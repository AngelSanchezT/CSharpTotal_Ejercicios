using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpTotal_Ejercicios
{
    public class ArchivoEventArgs : EventArgs
    {
        public Archivo Archivo { get; set; }
    }
    internal class AsistenteDescarga
    {
        //Paso 1 - Crear el delegado
        //public delegate void GestorEventoArchivoDescargado(object fuente, ArchivoEventArgs args);

        //paso 2 - Crear el evento basado en el delegado
        public event EventHandler<ArchivoEventArgs> ArchivoDescargado;

        //Paso 3 - Iniciar el evento
        protected virtual void EnArchivoDescargado(Archivo archivo)
        {
            if (ArchivoDescargado != null)
            {
                ArchivoDescargado(this, new ArchivoEventArgs() { Archivo = archivo });
            }
        }
        public void Descarga(Archivo archivo)
        {
            Console.WriteLine("Descargando archivo... ");
            Thread.Sleep(4000);

            //Paso 3.1
            EnArchivoDescargado(archivo);
        }
    }
}
