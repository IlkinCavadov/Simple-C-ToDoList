using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    public class Task
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public Task (string title)
        {
            Title = title;
            IsCompleted = false;
        }
    }

    class Program
    {
        static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===To-Do List===");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. List Task");
                Console.WriteLine("3. Complete the Task");
                Console.WriteLine("4. Delete the Task");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ListTask();
                        break;
                    case "3":
                        CompleteTask();
                        break;
                    case "4":
                        DeleteTask();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option! Try again!");
                        break;

                }


            }
        }

        static void Info()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = tasks[i].IsCompleted ? "[Comlepeted]" : "[Ongoing]";
                Console.WriteLine($"{i + 1}. {tasks[i].Title } {status}");

            }
        }

        static void AddTask()
        {
            Console.Write("Task title:  ");
            string title = Console.ReadLine();
            tasks.Add(new Task(title));
            Console.WriteLine("Tasks added!");
            Console.ReadLine();
        }

        static void ListTask()
        {
            Console.WriteLine("===Tasks===");
            if (tasks.Count == 0)
            {
                Console.WriteLine(" There is no Task Yet.");
            }
            else 
            {
                Info();
            }
            Console.WriteLine("Devam etmek için Enter'a basn.");
            Console.ReadLine();
        }

        static void CompleteTask()
        {
            Info();
            Console.Write("Enter the task number you want to complete:  ");
            int taskNumber = int.Parse(Console.ReadLine());
            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks[taskNumber - 1].IsCompleted = true;
                Console.WriteLine("Task is completed!");

            }
            else
            {
                Console.WriteLine("Taks number not exist!");
            }
            Console.ReadLine();
        }

        static void DeleteTask()
        {
            Console.Write(" Enter the task number you want to delete:  ");
            int taskNumber = int.Parse(Console.ReadLine());
            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine(" Your Task deleted succesfully!");

            }
            else
            {
                Console.WriteLine("Taks number not exist!");
            }
            Console.ReadLine();

        }

    }

}