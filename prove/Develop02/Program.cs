using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            string input;
            do
            {
                Console.WriteLine("Journal App");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        journal.WriteNewEntry();
                        break;
                    case "2":
                        journal.DisplayJournal();
                        break;
                    case "3":
                        journal.SaveJournalToFile();
                        break;
                    case "4":
                        journal.LoadJournalFromFile();
                        break;
                }
            } while (input != "5");
        }
    }
}