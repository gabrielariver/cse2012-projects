using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        LogActivity($"{_name} started at {DateTime.Now}");

        int endTime = Environment.TickCount + _duration * 1000;
        while (Environment.TickCount < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3);
            Console.WriteLine("Breathe out...");
            ShowSpinner(3);
        }
        DisplayEndingMessage();

        LogActivity($"{_name} completed at {DateTime.Now} with a duration of {_duration} seconds");
    }
}
