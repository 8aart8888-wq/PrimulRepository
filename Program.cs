using System;
namespace PrimulRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Primul meu repository ===");
            Console.Write("Introduceti numele dvs.: ");
            string nume = Console.ReadLine();
            Console.WriteLine($"Salut, {nume}! Acest proiect este versionat cu Git.");
        }
    }
}
