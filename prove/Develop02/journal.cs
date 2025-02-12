using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Journal
    {
        private List<Entry> _entries;
        private List<string> _prompts;

        public Journal()
        {
            _entries = new List<Entry>();
            _prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };
        }

        public void WriteNewEntry()
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            string _prompt = _prompts[index];
            Console.WriteLine(_prompt);
            string _response = Console.ReadLine();
            string _date = DateTime.Now.ToString("yyyy-MM-dd");
            _entries.Add(new Entry(_date, _prompt, _response));
        }

        public void DisplayJournal()
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry);
            }
        }

        public void SaveJournalToFile()
        {
            Console.Write("Enter filename to save to: ");
            string filename = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.ToCsv());
                }
            }
        }

        public void LoadJournalFromFile()
        {
            Console.Write("Enter filename to load from: ");
            string filename = Console.ReadLine();
            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    _entries.Add(Entry.FromCsv(line));
                }
            }
        }
    }
}