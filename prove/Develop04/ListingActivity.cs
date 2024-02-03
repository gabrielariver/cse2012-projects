using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Random rnd = new Random();

        if (_prompts.Count > 0)
        {
            Console.WriteLine(_prompts[rnd.Next(_prompts.Count)]);
        }
        else
        {
            Console.WriteLine("No prompts available.");
            return;
        }

        int endTime = Environment.TickCount + _duration * 1000;
        int count = 0;
        while (Environment.TickCount < endTime)
        {
            Console.WriteLine("Please list your items. Press enter after each item:");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                count++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine($"You have listed {count} items.");
        DisplayEndingMessage();
    }
}
