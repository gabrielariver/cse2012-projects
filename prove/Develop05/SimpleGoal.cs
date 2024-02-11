using System;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        _name = "Name of Simple Goal";
        _description = "Description of Simple Goal";
        _goalPoints = 50;
        _status = false;
    }

    public SimpleGoal(string name, string description, int goalPoints, bool status)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _status = status;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    public override void RecordEvent()
    {
        if (!_status) {
            _status = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        return _status;
    }

    public override void ListGoal()
    {
        string statusSymbol = IsComplete() ? "X" : " ";
        Console.Write($"[{statusSymbol}] {_name} ({_description})");
    }
    
    public override int CalculateAGP()
    {
        return IsComplete() ? _goalPoints : 0;
    }

    public override string SaveGoal()
    {
        return $"SimpleGoal:{_name},{_description},{_goalPoints},{_status}";
    }
}
