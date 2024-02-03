using System;
using System.Threading;
using System.IO;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("Enter the duration in seconds for this activity:");
        if (!int.TryParse(Console.ReadLine(), out _duration))
        {
            Console.WriteLine("Invalid input. Setting default duration to 60 seconds.");
            _duration = 60;
        }
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public abstract void Run();

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed:");
        Console.WriteLine($"{_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void LogActivity(string content)
    {
        string filePath = "ActivityLog.txt";
        try
        {
            File.AppendAllText(filePath, content + Environment.NewLine);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error logging activity: {ex.Message}");
        }
    }
}
