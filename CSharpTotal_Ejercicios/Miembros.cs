using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    class Miembros
    {
        //Miembros - Campos Privado
        private string nombrePersona;
        private string tituloTrabajo;
        private int salario;

        //Miembros - Campo Público
        public int edad;

        //Miembros - Propiedades
        public string TituloTrabajo
        {
            get
            {
                return tituloTrabajo;
            }
            set
            {
                tituloTrabajo = value;
            }
        }

        //Miembros - Método privado;
        private void CompartirInfoPrivada()
        {
            Console.WriteLine("Hola, mi salario es {0}", salario);
        }

        //Miembros - Métodos Públicos
        public void Amigo(bool esAmigo)
        {
            if (esAmigo)
            {
                CompartirInfoPrivada();
            }
            else
            {
                Console.WriteLine("Hola, mi nombre es {0}, y mi edad es {1}", nombrePersona, edad);
            }

        }

        //Miembros - Constructor
        public Miembros()
        {
            edad = 30;
            nombrePersona = "Ana";
            salario = 50000;
            tituloTrabajo = "Desarrollador";
            Console.WriteLine("Objeto creado");
        }

        //Miembros - Finalizador/Destructor
        ~Miembros()
        {
            //Limpia declaraciones
            Console.WriteLine("Destrucción de objeto miembro");
            Debug.Write("Destrucción de objeto miembro");
        }
    }
}
