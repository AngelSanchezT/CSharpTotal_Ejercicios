using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Caja
    {

        //DESAFÍO
        //Crea una Propiedad de solo lectura llamada SuperficieFrontal
        //Se calcula con las variables alto y largo


        //Miembros variables
        private string color = "blanco";
        private int largo;
        private int alto;
        // private int ancho;
        private int volumen;

        public Caja(int largo, int alto, int ancho)
        {
            this.largo = largo;
            this.alto = alto;
            this.Ancho = ancho;
        }


        public int Volumen
        {
            set
            {
                volumen = value;
            }
            get
            {
                return Alto * Ancho * Largo;
            }


        }

        public int Alto
        {
            get
            {
                return alto;
            }
            /*set
            {
                if (value < 0) value = -value; //throw new Exception("El tamaño debe ser positivo");
                alto = value;
            }*/
        }


        //Propiedad Auto-Implementada
        public int Ancho { get; set; }

        /*public int Largo
        {
            get
            {
                return largo;
            }
            set
            {
                largo = value;
            }
        }*/

        public int Largo
        {
            get => largo;
            set => largo = value;
        }

        public int SuperficieFrontal
        {
            get
            {
                return alto * largo;
            }
        }

        //Miembro método
        public void MuestraInfo()
        {
            Console.WriteLine("El largo es {0}. La altura es {1}. El ancho es {2}. Por lo tanto el volumen es {3}"
                , largo, alto, Ancho, volumen = Ancho * alto * largo);
        }

        /* public void SetLargo(int largo)
        {
            this.largo = largo;
        }

        public int GetLargo()
        {
            return this.largo;
        }
        */
    }
}
