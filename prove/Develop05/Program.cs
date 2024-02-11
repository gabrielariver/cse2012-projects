using System;
//As part of creativity, an option has been added to ask the user 
//if they are sure to leave or want to continue.
class Program
{
    static void Main(string[] args)
    {
        string menuSelected = "";
        bool userWantsToExit = false; 

        GoalManager goals = new GoalManager();

        while (!userWantsToExit)
        {
            int points = goals.GetAccumulatedPoints();

            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            menuSelected = Console.ReadLine();

            switch (menuSelected)
            {
                case "1":
                    Console.WriteLine("The Types of Goals are: ");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    switch (goalType)
                    {
                        case "1":
                            SimpleGoal newSimpleGoal = new SimpleGoal();
                            newSimpleGoal.CreateChildGoal();
                            goals.addGoal(newSimpleGoal);
                            break;

                        case "2":
                            EternalGoal newEternalGoal = new EternalGoal();
                            newEternalGoal.CreateChildGoal();
                            goals.addGoal(newEternalGoal);
                            break;

                        case "3":
                            ChecklistGoal newChecklistGoal = new ChecklistGoal();
                            newChecklistGoal.CreateChildGoal();
                            goals.addGoal(newChecklistGoal);
                            break;

                        default:
                            Console.WriteLine("Invalid goal type. Please try again.");
                            break;
                    }
                    break;

                case "2":
                    goals.ListGoals();
                    break;

                case "3":
                    goals.SaveGoals();
                    break;

                case "4":
                    goals.LoadGoals();
                    break;

                case "5":
                    goals.RecordEventInTracker();
                    break;

                case "6":
                    Console.WriteLine("Are you sure you want to quit? (yes/no)");
                    string exitConfirmation = Console.ReadLine().Trim().ToLower();
                    if (exitConfirmation == "yes")
                    {
                        Console.WriteLine("Would you like to start over instead of quitting? (yes/no)");
                        string startOverResponse = Console.ReadLine().Trim().ToLower();
                        if (startOverResponse == "yes")
                        {
                            Console.Clear(); 
                            continue;
                        }
                        else
                        {
                            userWantsToExit = true;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Please select a valid number from the menu options.");
                    break;
            }

            if (userWantsToExit)
            {
                Environment.Exit(0);
            }
        }
    }
}