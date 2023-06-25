using System;
using System.Collections.Generic;
using System.IO;

public class GoalTracker
{
    private List<Goal> _goals;
    private int _totalScore;

    public int Score
    {
        get { return _totalScore; }
    }

    public GoalTracker()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public void CreateGoal(string _goalType, params object[] args)
    {
        if (_goalType == "simple")
        {
            string _name = (string)args[0];
            int points = (int)args[1];
            Goal _goal = new SimpleGoal(_name, points);
            _goals.Add(_goal);
        }
        else if (_goalType == "eternal")
        {
            string _name = (string)args[0];
            int points = (int)args[1];
            Goal _goal = new EternalGoal(_name, points);
            _goals.Add(_goal);
        }
        else if (_goalType == "checklist")
        {
            string _name = (string)args[0];
            int _perCompletionPoints = (int)args[1];
            int _targetCount = (int)args[2];
            int _bonusPoints = (int)args[3];
            Goal _goal = new ChecklistGoal(_name, _perCompletionPoints, _targetCount, _bonusPoints);
            _goals.Add(_goal);
        }
        else
        {
            throw new ArgumentException("Invalid _goal type");
        }
    }

    public int GetScore()
    {
        return _totalScore;
    }

    public void RecordEvent(string goalName)
    {
        foreach (Goal _goal in _goals)
        {
            if (_goal.Name == goalName && !_goal.Completed)
            {
                if (_goal is SimpleGoal _simpleGoal)
                {
                    _goal.MarkComplete();
                    _totalScore += _goal.Score;
                }
                if (_goal is EternalGoal _eternalGoal)
                {
                    _totalScore += _eternalGoal.Points;
                }
                if (_goal is ChecklistGoal _checklistGoal)
                {
                    if (_checklistGoal.Completions != _checklistGoal.TargetCount)
                    {
                        _goal.MarkComplete();
                        _totalScore += _checklistGoal.PerCompletionPoints;
                    }
                    if (_checklistGoal.Completions == _checklistGoal.TargetCount)
                    {
                        _goal.MarkComplete();
                        _totalScore += _checklistGoal.BonusPoints;
                    }
                }
                break;
            }   
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("========== Goals ==========");
        Console.WriteLine("Score: " + _totalScore);
        foreach (Goal _goal in _goals)
        {
            string _completionStatus = _goal.Completed ? "[X]" : "[ ]";
            if (_goal is SimpleGoal _simpleGoal)
            {
                Console.WriteLine($"{_completionStatus} {_goal.Name} (Points: {_simpleGoal.Points})");
            }
            else if (_goal is EternalGoal _eternalGoal)
            {
                Console.WriteLine($"{_completionStatus} {_goal.Name} (Points: {_eternalGoal.Points})");
            }
            else if (_goal is ChecklistGoal _checklistGoal)
            {
                string _progress = _checklistGoal.GetProgress();
                Console.WriteLine($"{_completionStatus} {_goal.Name} ({_progress})");
                if (_checklistGoal.Completed)
                {
                    Console.WriteLine("Goal Completed!");
                }
            }
        }
    }

    internal void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Goal _goal in _goals)
            {
                if (_goal is SimpleGoal _simpleGoal)
                {
                    writer.WriteLine($"{_goal.GetType().Name}|{_goal.Name}|{_goal.Completed}|{GetPossiblePoints(_goal)}");
                }
                if (_goal is EternalGoal _eternalGoal)
                {
                    writer.WriteLine($"{_goal.GetType().Name}|{_goal.Name}|{_goal.Completed}|{GetPossiblePoints(_goal)}");
                }
                if (_goal is ChecklistGoal _checklistGoal)
                {
                    writer.WriteLine($"{_goal.GetType().Name}|{_goal.Name}|{_goal.Completed}|{GetPossiblePoints(_goal)}|{_checklistGoal.TargetCount}|{_checklistGoal.BonusPoints}|{_checklistGoal.Completions}");
                }
            }
            writer.WriteLine($"_totalScore|{_totalScore}|True|0");
        }
        Console.WriteLine("Goals saved successfully.");
    }

    internal void LoadGoals(string filePath)
    {
        _goals.Clear();
        _totalScore = 0;
        using (StreamReader reader = new StreamReader(filePath))
        {
            string _line;
            while ((_line = reader.ReadLine()) != null)
            {
                string[] _parts = _line.Split('|');
                string _goalType = _parts[0];
                string _name = _parts[1];
                bool _completed = bool.Parse(_parts[2]);
                int _score = int.Parse(_parts[3]);
                if (_goalType == "SimpleGoal")
                {
                    Goal _goal = new SimpleGoal(_name, _completed, _score);
                    _goals.Add(_goal);
                }
                if (_goalType == "EternalGoal")
                {
                    Goal _goal = new EternalGoal(_name, _completed, _score);
                    _goals.Add(_goal);
                }
                if (_goalType == "ChecklistGoal")
                {
                    int _perCompletionPoints = int.Parse(_parts[3]);
                    int _targetCount = int.Parse(_parts[4]);
                    int _bonusPoints = int.Parse(_parts[5]);
                    int completions = int.Parse(_parts[6]);
                    Goal _goal = new ChecklistGoal(_name, _completed, _perCompletionPoints, _targetCount, _bonusPoints, completions);
                    _goals.Add(_goal);
                }
                if ( _parts[0] == "_totalScore")
                {
                    _totalScore = int.Parse(_parts[1]);
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }


    private int GetPossiblePoints(Goal _goal)
    {
        if (_goal is SimpleGoal _simpleGoal)
        {
            return _simpleGoal.Points;
        }
        else if (_goal is EternalGoal _eternalGoal)
        {
            return _eternalGoal.Points;
        }
        else if (_goal is ChecklistGoal _checklistGoal)
        {
            return _checklistGoal.PerCompletionPoints;
        }
        return 0;
    }

}