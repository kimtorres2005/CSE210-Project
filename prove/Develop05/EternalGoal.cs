public class EternalGoal : Goal
{
    public EternalGoal(string name, bool completed, int points)
    {
        Name = name;
        Completed = completed;
        Points = points;
    }

    public EternalGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public int Points { get; set; }

    protected override int GetCurrentGoalScore()
    {
        return Points;
    }

    public override void MarkComplete()
    {
        // Override the MarkComplete method to prevent eternal goals from being marked as completed
        // Remove the implementation so that eternal goals cannot be completed
    }

    public void DisplayGoal()
    {
        Console.WriteLine("Goal Name: " + Name);
        Console.WriteLine("Points: " + Points);
        Console.WriteLine("Completion Status: Incomplete");
    }
}