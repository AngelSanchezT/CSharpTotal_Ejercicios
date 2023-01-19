using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    /*
     * Desafío de Herencia 2 - Empleados, Jefes y Pasantes
     * 
     * 1. Crea una Clase principal con un método Main.
     * 2. Luego una Clase Base llamada Empleado con:
     *      Propiedades Nombre, Apellido, Salario
     *      Métodos
     *          Trabajar() - Hace que se imprima en consola "Estoy trabajando"
     *          Descansar() - Hace que se imprima en consola "Estoy Descansando"
     *      Constructores
     * 3. Crea una Clase Derivada llamada Jefe con:
     *      Propiedad AutoDeEmpresa - Declara la marca del auto que posee
     *      Método Dirigir() - Hace que se imprima en consola "Soy el jefe"
     *      Constructores
     * 4. Crea otra Clase Derivada llamada Pasante con:
     *      Propiedades HorasDeTrabajo y HorasDeEscuela - Son dos integers que 
     *      declaran la cantidad de horas que trabajan y aprenden por semana
     *      
     *      Método Aprender() - Hace que se imprima en consola "Estoy aprendiendo 
     *      durante X cantidad de horas"
     *      
     * 5. Sobreescribe el método Trabajar() en la Clase Pasante para que indique 
     * la cantidad de horas semanales de trabajo del pasante.
     * 
     * 6. Crea un objeto de cada una de las 3 clases con los valores que prefieras
     * 
     * 7. Llama a los métodos Dirigir() del Jefe y Trabajar() del pasante
     * 
     */
    internal class Desafio9
    {
        public static void Principal() 
        {
            Empleado miguel = new Empleado("Miguel", " Flores", 4000);
            miguel.Trabajar();
            miguel.Descansar();

            Jefe chuckNorris = new Jefe("Ferrari", " Chuck", "Norris", 9999999);
            chuckNorris.Dirigir();

            Pasante laura = new Pasante(15, 20, "Laura", "Casas", 2000);
            laura.Trabajar();
            laura.Aprender();

            Console.Read();
        }

    }
}
