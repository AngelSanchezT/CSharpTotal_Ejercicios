using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class ArrayListsCurso
    {
        public static void Principal()
        {
            //Declarar un ArrayList indeterminado
            ArrayList miArrayList = new ArrayList();

            //Declarar un ArrayList determinado
            ArrayList miArrayList2 = new ArrayList(100);

            //Agregar elementos al ArrayList
            miArrayList.Add(25);
            miArrayList.Add("Hola");
            miArrayList.Add(13.37);
            miArrayList.Add(13);
            miArrayList.Add(128);
            miArrayList.Add(25.3);
            miArrayList.Add(13);

            //Eliminar elementos del arrayList por valor
            miArrayList.Remove(13);
            miArrayList.Remove(13);
            miArrayList.Remove(13);

            //Eliminar elementos del arrayList por índice
            miArrayList.RemoveAt(0);

            //Contar elementos del arrayList
            Console.WriteLine(miArrayList.Count);

            double suma = 0;

            foreach (object obj in miArrayList)
            {
                if (obj is int)
                {
                    suma += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    suma += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }


            }

            Console.WriteLine(suma);
            Console.Read();
        }
    }
}
