using System;

public class EternalGoal : Goal
{
    private int _stepCounter;

    public EternalGoal()
    {
        _name = "Default Eternal Goal";
        _description = "Default Description";
        _goalPoints = 50;
        _stepCounter = 0;
    }

    public EternalGoal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _stepCounter = 0;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    public override void ListGoal()
    {
        Console.Write($"[ ] {_name} ({_description})");
    }

    public override bool IsComplete()
    {
        return false; 
    }

    public override string SaveGoal()
    {
        return $"EternalGoal:{_name},{_description},{_goalPoints}";
    }

    public override void RecordEvent()
    {
        _stepCounter++;
    }

    public override int CalculateAGP()
    {
        return _goalPoints; 
    }
}
