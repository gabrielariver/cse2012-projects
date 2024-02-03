using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "TThink of a time when you helped someone in need.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done something like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
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
        }

        int endTime = Environment.TickCount + _duration * 1000;
        while (Environment.TickCount < endTime)
        {
            if (_questions.Count > 0)
            {
                Console.WriteLine(_questions[rnd.Next(_questions.Count)]);
            }
            else
            {
                Console.WriteLine("No questions available.");
            }
            ShowSpinner(3);
        }
        DisplayEndingMessage();
    }
}
