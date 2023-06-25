using System;

public class Goal
{
    public string Name { get; set; }
    public bool Completed { get; set; }
    public int Score { get; protected set; }

    public virtual void MarkComplete()
    {
        Completed = true;
        Score += GetCurrentGoalScore();
    }

    protected virtual int GetCurrentGoalScore()
    {
        return 0;
    }

    internal void SetCompletionStatus(bool completed)
    {
        Completed = completed;
    }

}