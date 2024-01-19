using System;
//entry class
public class Entry
{
    public string Date { get; }
    public string Prompt { get; }
    public string Response { get; }
    public string Mood { get; }

    public Entry(string date, string prompt, string response, string mood)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {Prompt}");
        Console.WriteLine($"{Response}");
        Console.WriteLine($"Mood: {Mood}");
        Console.WriteLine();
    }
}
