using System;
using System.Collections.Generic;


class Program
{
    private GoalTracker _tracker;

    public Program()
    {
        _tracker = new GoalTracker();
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("========== Goal Tracker ==========");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your _choice: ");
            string _choice = Console.ReadLine();

            if (_choice == "1")
            {
                CreateGoal();
            }
            else if (_choice == "2")
            {
                RecordEvent();
            }
            else if (_choice == "3")
            {
                DisplayGoals();
            }
            else if (_choice == "4")
            {
                SaveGoals();
            }
            else if (_choice == "5")
            {
                LoadGoals();
            }
            else if (_choice == "6")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid _choice. Please try again.");
            }

            // Display the score after each operation
            Console.WriteLine("Score: " + _tracker.GetScore());
            Console.WriteLine();
        }
    }


    private void CreateGoal()
    {
        Console.WriteLine("========== Create Goal ==========");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter the goal type: ");
        string _goalType = Console.ReadLine();

        if (_goalType == "1")
        {
            Console.Write("Enter the goal _name: ");
            string _name = Console.ReadLine();
            Console.Write("Enter the points for completing the goal: ");
            int points = int.Parse(Console.ReadLine());
            _tracker.CreateGoal("simple", _name, points);
        }
        else if (_goalType == "2")
        {
            Console.Write("Enter the goal _name: ");
            string _name = Console.ReadLine();
            Console.Write("Enter the points for each completion: ");
            int points = int.Parse(Console.ReadLine());
            _tracker.CreateGoal("eternal", _name, points);
        }
        else if (_goalType == "3")
        {
            Console.Write("Enter the goal _name: ");
            string _name = Console.ReadLine();
            Console.Write("Enter the points for each completion: ");
            int _perCompletionPoints = int.Parse(Console.ReadLine());
            Console.Write("Enter the target completion count: ");
            int _targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus points for achieving the target: ");
            int _bonusPoints = int.Parse(Console.ReadLine());
            _tracker.CreateGoal("checklist", _name, _perCompletionPoints, _targetCount, _bonusPoints);
        }
        else
        {
            Console.WriteLine("Invalid goal type. Please try again.");
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("========== Record Event ==========");
        Console.Write("Enter the _name of the goal to record an event: ");
        string _goalName = Console.ReadLine();
        _tracker.RecordEvent(_goalName);
    }

    private void DisplayGoals()
    {
        Console.WriteLine("========== Goals ==========");
        Console.WriteLine("Score: " + _tracker.GetScore());
        _tracker.DisplayGoals();
    }


    private void SaveGoals()
    {
        Console.Write("Enter the file path to save goals: ");
        string filePath = Console.ReadLine();
        _tracker.SaveGoals(filePath);
        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        Console.Write("Enter the file path to load goals: ");
        string filePath = Console.ReadLine();
        _tracker.LoadGoals(filePath);
        Console.WriteLine("Goals loaded successfully.");
    }

    static void Main(string[] args)
    {
        Program _program = new Program();
        _program.Run();
    }
}