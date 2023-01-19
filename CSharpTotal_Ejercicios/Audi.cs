using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Audi:Auto
    {
        //Variables
        private string marca = "Audi";

        //Propiedad
        public string Modelo { get; set; }

        //Constructor
        public Audi(int hp, string color, string modelo) : base(hp, color)
        {
            this.Modelo = modelo;
        }

        //Métodos
        public void MostrarDetalles()
        {
            Console.WriteLine("Marca: {0} - Modelo: {1} - HP: {2} - Color: {3}", marca, Modelo, HP, Color);
        }

        public override void Reparar()
        {
            Console.WriteLine("El Audi {0} está reparado", Modelo);
        }
    }
}
