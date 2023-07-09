using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    private List<Goal> _goals;
    private int _score;
    private GoalTracker _goalTracker;

    public Program()
    {
        _goals = new List<Goal>();
        _score = 0;
        _goalTracker = new GoalTracker();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        if (!goal.ItsComplete)
        {
            goal.Complete();
            _score += goal.Value;
            Console.WriteLine("Event recorded!");
            Console.WriteLine($"Current Score: {_score}");

        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine();
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            goal.Display();
        }
    }

    public void SaveGoals(string fileName)
    {
        _goalTracker.SaveGoalsToFile(_goals, _score, fileName);
    }

    public void LoadGoals(string fileName)
    {
        (_goals, _score) = _goalTracker.LoadGoalsFromFile(fileName);
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine();
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Enter a choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Types of goals:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine();
                    Console.Write("Enter a goal type: ");
                    int goalType = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter what you want to name the goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the value of the goal: ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (goalType)
                    {
                        case 1:
                            AddGoal(new SimpleGoal(name, value, false));
                            break;
                        case 2:
                            AddGoal(new EternalGoal(name, value, false));
                            break;
                        case 3:
                            Console.Write("Enter the required times for the goal to be marked complete: ");
                            int requiredTimes = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the bonus value for completing the goal: ");
                            int bonus = Convert.ToInt32(Console.ReadLine());
                            bool isComplete = false;
                            int timesCompleted = 0;
                            AddGoal(new ChecklistGoal(name, value, isComplete, timesCompleted, requiredTimes, bonus));
                            break;
                        default:
                            Console.WriteLine("Invalid goal type.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Select what goal you would like to record: ");
                    for (int i = 0; i < _goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {_goals[i].Name}");
                    }
                    Console.Write("Enter the goal number: ");
                    int goalNumber = Convert.ToInt32(Console.ReadLine());

                    if (goalNumber > 0 && goalNumber <= _goals.Count)
                    {
                        RecordEvent(_goals[goalNumber - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    DisplayGoals();
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write("Enter what file you want to load goals from: ");
                    string loadFileName = Console.ReadLine();
                    LoadGoals(loadFileName);
                    Console.WriteLine("Goals loaded!");
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Write("Enter file name to save goals: ");
                    string saveFileName = Console.ReadLine();
                    SaveGoals(saveFileName);
                    Console.WriteLine("Goals saved!");
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("Remember to enter the goals as you complete them. Goodbye!");
                    Console.WriteLine();
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        Program eternalQuest = new Program();
        eternalQuest.Run();
    }
}
