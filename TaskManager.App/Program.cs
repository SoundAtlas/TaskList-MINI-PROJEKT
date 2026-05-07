using System.Text.Json;

namespace TaskManager.Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


// === TaskManager.App/Program.cs ===

using TaskManager.Core.Models;
using TaskManager.Core.Repositories;
using TaskManager.Core.Exceptions;

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

    // TODO:
    // switch der kalder de relevante metoder

    // TODO:
    // Brug try/catch til at fange TaskNotFoundException

    // TODO:
    // Brug try/catch til at fange FormatException ved int.Parse
}