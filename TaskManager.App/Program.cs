using TaskManager.Core.Exceptions;
using TaskManager.Core.Models;
using TaskManager.Core.Repositories;

namespace TaskManager.Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            ITaskRepository repo = new JsonTaskRepository("tasks.json");

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== Opgaveliste ===");

                Console.WriteLine("1. Vis alle opgaver");
                Console.WriteLine("2. Tilfoej arbejdsopgave");
                Console.WriteLine("3. Tilfoej personlig opgave");
                Console.WriteLine("4. Marker som faerdig");
                Console.WriteLine("5. Slet opgave");
                Console.WriteLine("6. Gem og afslut");

                Console.Write("Valg: ");

                string choice = Console.ReadLine() ?? "";


                try
                {
                    switch (choice)
                    {
                        case "1":
                            foreach (TaskBase task in repo.GetAll())
                            {
                                Console.WriteLine(task.Describe());
                            }
                            break;

                        case "2":
                            WorkTask workTask = new WorkTask();

                            Console.Write("Title: ");
                            workTask.Title = Console.ReadLine() ?? "";

                            Console.Write("Project: ");
                            workTask.Project = Console.ReadLine() ?? "";

                            repo.Add(workTask);
                            break;

                        case "3":
                            PersonalTask personalTask = new PersonalTask();

                            Console.Write("Title: ");
                            personalTask.Title = Console.ReadLine() ?? "";

                            Console.Write("Category: ");
                            personalTask.Category = Console.ReadLine() ?? "";

                            repo.Add(personalTask);
                            break;

                        case "4":
                            Console.Write("Id: ");
                            int doneId = int.Parse(Console.ReadLine() ?? "");
                            repo.MarkDone(doneId);
                            break;

                        case "5":
                            Console.Write("Id: ");
                            int deleteId = int.Parse(Console.ReadLine() ?? "");
                            repo.Remove(deleteId);
                            break;

                        case "6":
                            repo.Save();
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                catch (TaskNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Write a valid whole number");
                }
                // TODO:
                // switch der kalder de relevante metoder

                // TODO:
                // Brug try/catch til at fange TaskNotFoundException

                // TODO:
                // Brug try/catch til at fange FormatException ved int.Parse
            }
        }
    }
}
