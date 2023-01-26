using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class EventosYDelegados
    {
        public static void Principal()
        {
            var archivo = new Archivo() { Titulo = "Archivo 1" };
            var asistenteDescarga = new AsistenteDescarga(); //emisor
            var servicioDesempacar = new ServicioDesempacar();//receptor
            var servicioNotificacion = new ServicioNotificacion(); //receptor

            asistenteDescarga.ArchivoDescargado += servicioDesempacar.EnArchivoDescargado;
            asistenteDescarga.ArchivoDescargado += servicioNotificacion.EnArchivoDescargado;
            asistenteDescarga.Descarga(archivo);
            Console.ReadKey();
        }
    }
}
