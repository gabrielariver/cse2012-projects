using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _accumulatedPoints = 0;

    public int GetAccumulatedPoints()
    {
        return _accumulatedPoints;
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_accumulatedPoints.ToString());
            
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear(); 

        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        if (lines.Length > 0)
        {
            _accumulatedPoints = Convert.ToInt32(lines[0]);
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            if (parts.Length < 2) continue;
            string[] goalData = parts[1].Split(',');

            switch (parts[0])
            {
                case "SimpleGoal":
                    if (goalData.Length == 4)
                    {
                        _goals.Add(new SimpleGoal(goalData[0], goalData[1], Convert.ToInt32(goalData[2]), Convert.ToBoolean(goalData[3])));
                    }
                    break;
                case "EternalGoal":
                    if (goalData.Length == 3)
                    {
                        _goals.Add(new EternalGoal(goalData[0], goalData[1], Convert.ToInt32(goalData[2])));
                    }
                    break;
                case "ChecklistGoal":
                    if (goalData.Length == 6)
                    {
                        _goals.Add(new ChecklistGoal(goalData[0], goalData[1], Convert.ToInt32(goalData[2]), Convert.ToInt32(goalData[3]), Convert.ToInt32(goalData[4]), Convert.ToInt32(goalData[5])));
                    }
                    break;
            }
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].ListGoal();
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void addGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int CalculateTotalAGP()
    {
        int totalAGP = _accumulatedPoints;
        foreach (Goal goal in _goals)
        {
            totalAGP += goal.CalculateAGP();
        }

        _accumulatedPoints = totalAGP;

        return totalAGP;
    }

    public void RecordEventInTracker()
    {
        Console.Write("Which goal did you accomplish? ");
        string goalIndex = Console.ReadLine();
        int goalIndexInt = Convert.ToInt32(goalIndex) - 1;

        if (goalIndexInt >= 0 && goalIndexInt < _goals.Count)
        {
            if (!_goals[goalIndexInt].IsComplete())
            {
                _goals[goalIndexInt].RecordEvent();
                int pointsEarned = _goals[goalIndexInt].CalculateAGP();
                _accumulatedPoints += pointsEarned;
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_accumulatedPoints} points");
            }
            else
            {
                Console.WriteLine("You have already completed this goal.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
}
