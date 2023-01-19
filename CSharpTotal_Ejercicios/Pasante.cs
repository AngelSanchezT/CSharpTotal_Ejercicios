using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Pasante : Empleado
    {
        //Propiedades
        public int HorasDeTrabajo { get; set; }
        public int HorasDeEscuela { get; set; }

        //Constructor
        public Pasante(int horasDeTrabajo, int horasDeEscuela, string nombre, string apellido, int salario) : base(nombre, apellido, salario)
        {
            this.HorasDeTrabajo = horasDeTrabajo;
            this.HorasDeEscuela = horasDeEscuela;
        }

        public void Aprender()
        {
            Console.WriteLine("Estoy aprendiendo durante {0} horas", HorasDeEscuela);
        }

        public void Trabajar()
        {
            Console.WriteLine("Estoy trabajando durante {0} horas", HorasDeTrabajo);
        }

    }
}
