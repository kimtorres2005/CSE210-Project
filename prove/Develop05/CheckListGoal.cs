using System;
using System.Collections.Generic;

public class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, bool completed, int perCompletionPoints, int targetCount, int bonusPoints, int completions)
    {
        Name = name;
        Completed = completed;
        PerCompletionPoints = perCompletionPoints;
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        Completions = completions;
    }

    public ChecklistGoal(string name, int perCompletionPoints, int targetCount, int bonusPoints)
    {
        Name = name;
        PerCompletionPoints = perCompletionPoints;
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
    }

    public ChecklistGoal(string name, int perCompletionPoints, int targetCount, int bonusPoints, int completions) : this(name, perCompletionPoints, targetCount, bonusPoints)
    {
    }

    public int PerCompletionPoints { get; set; }
    public int TargetCount { get; set; }
    public int BonusPoints { get; set; }
    public int Completions { get; set; }

    public override void MarkComplete()
    {
        if (Completions >= TargetCount)
        {
            Score += BonusPoints;
            base.MarkComplete();
        }
        else
        {
            Score += PerCompletionPoints;
            Completions++;
            if (Completions >= TargetCount)
            {
                Score += BonusPoints;
                base.MarkComplete();
            }
        }
    }

    protected override int GetCurrentGoalScore()
    {
        int _totalScore = 0;
        if (Completions == TargetCount)
        {
            _totalScore += BonusPoints;
        }
        _totalScore += Completions * PerCompletionPoints;
        return _totalScore;
    }

    public string GetProgress()
    {
        string checkbox = Completions >= TargetCount ? "[x]" : $"[{PerCompletionPoints}]";
        return $"{checkbox} Completed {Completions}/{TargetCount} times";
    }
}