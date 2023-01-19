using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Auto
    {
        //Propiedades
        public int HP { get; set; }
        public string Color { get; set; }

        // TIENE una relacion con AutoInfo
        protected AutoInfo autoInfo = new AutoInfo();

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

        public void SetearAutoInfo(int id, string propietario) 
        {
            autoInfo.ID = id;
            autoInfo.Propietario = propietario;
        }

        public void LeerAutoInfo()
        {
            Console.WriteLine("El ID del auto es {0} y su propietario es {1} ", autoInfo.ID, autoInfo.Propietario);
        }
    }
}
