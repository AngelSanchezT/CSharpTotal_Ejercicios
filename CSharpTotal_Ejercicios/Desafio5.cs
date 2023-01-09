using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpTotal_Ejercicios
{

    /*
     * Desafío - Declaraciones If
     * 
     * Crea un sistema de inicio de sesión de usuario, donde el usuario puede 
     * primero registrarse y luego iniciar sesión. El programa debe verificar 
     * si el usuario ha ingresado el nombre de usuario y la contraseña correctos 
     * al iniciar sesión (por lo tanto, los mismos que utilizó al registrarse).
     * 
     * Todavía no hemos explicado cómo hacer almacenamiento de datos, por lo 
     * tanto solo crea el programa de una manera que, al registrarse e iniciar sesión, 
     * ocurra en la misma ejecución del programa.
     * 
     * Utiliza declaraciones If, ingresos del usuario y métodos para resolver el desafío.
     */
    internal class Desafio5
    {
        static string nombreDeUsuario;
        static string clave;
        public static void Principal() 
        {
            Registro();
            Ingreso();

            Console.Read();        
        }

        public static void Registro() 
        {
            Console.WriteLine("Por favor ingrese su nombre de usuario");
            nombreDeUsuario = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su clave");
            clave = Console.ReadLine();
            Console.WriteLine("Registro exitoso");
            Console.WriteLine("----------------");
        }

        public static void Ingreso() 
        {
            Console.WriteLine("Por favor ingrese su nombre de usuario");
            string _nombreDeUsuario = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su clave");
            string _clave = Console.ReadLine();
            if (nombreDeUsuario == _nombreDeUsuario && clave == _clave)
            {
                Console.WriteLine("Ingreso exitoso!");
            }
            else 
            {
                Console.WriteLine("Nombre de Usuario y/o Clave, por favor reinicie el programa");
            }
        }


    }
}
