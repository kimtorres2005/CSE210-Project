public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value, bool isComplete) : base(name, value)
    {
        ItsComplete = isComplete;
    }

    public override void Complete()
    {
        ItsComplete = true;
    }

    public override void Display()
    {
        Console.WriteLine($"{GetStatus()}: Goal: {Name}: Possible Points: {Value}");
    }

    public override string GetStatus()
    {
        return ItsComplete ? "[X]" : "[ ]";
    }
}
