public class SimpleGoal : Goal
{
    public SimpleGoal(string name, bool completed, int points)
    {
        Name = name;
        Completed = completed;
        Points = points;
    }

    public SimpleGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public int Points { get; set; }

    protected override int GetCurrentGoalScore()
    {
        return Points;
    }

    public void DisplayGoal()
    {
        Console.WriteLine("Goal Name: " + Name);
        Console.WriteLine("Points: " + Points);
        Console.WriteLine("Completion Status: " + (Completed ? "Complete" : "Incomplete"));
    }
}