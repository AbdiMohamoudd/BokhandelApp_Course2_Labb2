using BokhandelApp;
using System;
using System.Linq;

namespace BokhandelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BokhandelEntities())
            {
                Console.WriteLine("Databaskoppling lyckades!");

                var böcker = db.Böcker.ToList();
                Console.WriteLine("Böcker i databasen:");
                foreach (var bok in böcker)
                {
                    Console.WriteLine($"- {bok.Titel}, {bok.Språk}, {bok.Pris} kr");
                }
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta...");
            Console.ReadKey();
        }
    }
}
