using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class M3 : BMW
    {
        //Constructor
        public M3(int hp, string color, string modelo) : base(hp, color, modelo)
        {
            this.Modelo = modelo;
        }

    }
}
