using System;
using System.Collections.Generic;

namespace To_do_list
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void AddTask()
        {
            Console.WriteLine("Add a task to your list: ");
            string inputTask = Console.ReadLine();
            tasks.Add(inputTask);
        }

        static void RemoveTask()
        {
            Console.WriteLine("What position of the task do you want to remove?");
            int position = int.Parse(Console.ReadLine());
            position -= position;
            tasks.RemoveAt(position);
            Console.WriteLine("Task removed!");
        }

        static void ViewList()
        {
            foreach (string task in tasks) 
            {
                Console.WriteLine("-> " + task + ";");
            }
        }

        static void Main(string[] args)
        {

            int option;
            Console.WriteLine("Welcome to your to do list!");

            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a task to your list.");
                Console.WriteLine("2. Remove a task from your list.");
                Console.WriteLine("3. View your list.");
                Console.WriteLine("0. Exit the program.");
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    AddTask();
                }
                if (option == 2)
                {
                    RemoveTask();
                }
                if (option == 3)
                {
                    ViewList();
                }
            } while (option != 0);
        }
    }
}
