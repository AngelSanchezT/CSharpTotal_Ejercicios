using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class Desafio10
    {
        /**
         *  Crea una clase básica Auto con:
         *  - 2 Propiedades: * HP
         *                   * Color
         *  - 1 Constructor parametrizado
         *  - 2 Métodos:     * MostrarDetalles() que muestre esas propiedades
         *                   * Reparar() que diga "Auto reparado"
         *  
         *  Crea dos clases derivadas: BMW y Audi con:
         *  - Su propio constructor parametrizado
         *  - 1 propiedad exclusiva: Modelo
         *  - 1 variable "Marca", que ya debe tener valor asignado por defecto (BMW o Audi)
         *  - Sus propios metodos Reparar() y MostrarDetalles() adaptados.
         */
        public static void Principal()
        {
            var autos = new List<Auto>
            {
                new Audi(200,"azul","A4"),
                new BMW(250, "rojo","M3")
            };

            foreach (var auto in autos)
            {
                auto.Reparar();
            }

            Auto auto1 = new BMW(200, "negro", "Z3");
            Auto auto2 = new Audi(100, "verde", "A3");

            auto1.MostrarDetalles();
            auto2.MostrarDetalles();

            BMW bmwM5 = new BMW(330, "blanco", "M5");
            bmwM5.MostrarDetalles();

            Auto autoB = (Auto)bmwM5;
            autoB.MostrarDetalles();

            Console.Read();
        }
    }
}
