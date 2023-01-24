using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTotal_Ejercicios
{
    internal class ToDo
    {
        public static List<string> TaskList { get; set; } 

        public static void Principal()
        {
           
            int menuSelected = 0;
            do
            {
                TaskList = new List<string>();
                menuSelected = ShowMainMenu();
                if ((Menu)menuSelected == Menu.Add)
                {
                    ShowMenuAdd();
                }
                else if ((Menu)menuSelected == Menu.Remove)
                {
                    ShowMenuRemove();
                }
                else if ((Menu)menuSelected == Menu.List)
                {
                    ShowMenuTaskList();
                }
            } while ((Menu)menuSelected != Menu.Exit);
        }

        /// <summary>
        /// Show the main menu 
        /// </summary>
        /// <returns>Returns option indicated by user</returns>
        public static int ShowMainMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ingrese la opción a realizar: ");
            Console.WriteLine("1. Nueva tarea");
            Console.WriteLine("2. Remover tarea");
            Console.WriteLine("3. Tareas pendientes");
            Console.WriteLine("4. Salir");

            // Read line
            string menuSelected = Console.ReadLine();
            return Convert.ToInt32(menuSelected);
        }

        public static void ShowMenuRemove()
        {
            try
            {
                Console.WriteLine("Ingrese el número de la tarea a remover: ");
                // Show current taks
                ShowTaskList();

                string taskSelected = Console.ReadLine();
                // Remove one position
                int indexToRemove = Convert.ToInt32(taskSelected) - 1;

                if (indexToRemove > (TaskList.Count  - 1 ) || indexToRemove < 0) 
                {
                    Console.WriteLine("Numero de tarea seleccionado no es valido");
                } 
                else
                {
                    if (indexToRemove > -1 && TaskList.Count > 0)
                    {
                        string taskRemove = TaskList[indexToRemove];
                        TaskList.RemoveAt(indexToRemove);
                        Console.WriteLine($"Tarea {taskRemove} eliminada");

                    }
                }                
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error al eliminar la tarea");
            }
        }

        public static void ShowMenuAdd()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la tarea: ");
                string nameTask = Console.ReadLine();
                TaskList.Add(nameTask);
                Console.WriteLine("Tarea registrada");
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error al adicionar la tarea a la lista");
            }
        }

        public static void ShowMenuTaskList()
        {
            if (TaskList?.Count > 0)
            {
                ShowTaskList();
            }
            else
            {
                Console.WriteLine("No hay tareas por realizar");
            }
        }

        public static void ShowTaskList()
        {
            var indexTask = 1;
            Console.WriteLine("----------------------------------------");
            TaskList.ForEach(task => Console.WriteLine($"{indexTask++}. {task}" ));
            Console.WriteLine("----------------------------------------");
        }
    }

    public enum Menu
    {
        Add = 1,
        Remove = 2,
        List = 3,
        Exit = 4
    }
}
