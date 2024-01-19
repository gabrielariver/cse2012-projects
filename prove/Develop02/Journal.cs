using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void WriteEntry(string prompt)
    {
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        Console.Write("How do you feel today? ");
        string mood = Console.ReadLine();

        _entries.Add(new Entry(date, prompt, response, mood));
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveJournal()
    {
        Console.Write("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                sw.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}|{entry.Mood}");
            }
        }
        Console.WriteLine("Journal saved.");
    }

    public void LoadJournal()
    {
        Console.Write("Enter a filename to load the journal: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        using (StreamReader sr = new StreamReader(filename))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 4)
                {
                    _entries.Add(new Entry(parts[0], parts[1], parts[2], parts[3]));
                }
            }
        }
        Console.WriteLine("Journal loaded.");
    }
}
