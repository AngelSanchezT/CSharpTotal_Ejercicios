using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Auto
    {
        //Propiedades
        public int HP { get; set; }
        public string Color { get; set; }

        //Constructor parametrizado
        public Auto(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        //Métodos
        public void MostrarDetalles()
        {
            Console.WriteLine("HP: {0} - Color: {1}", HP, Color);
        }

        public virtual void Reparar()
        {
            Console.WriteLine("El auto ya está reparado");
        }
    }
}
