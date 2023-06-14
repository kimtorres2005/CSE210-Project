using System;
using System.Threading;

class Activity
{
    private int _counter;

    protected int Duration { get; set; }
    protected string ActivityName { get; set; }
    protected string Description { get; set; }

    // Introduction function for each activity.
// Introduction function for each activity.
public virtual void Introduction()
{
    Console.WriteLine($"Welcome to the {ActivityName}.\n");
    Console.WriteLine(Description);
    Duration = GetDur();
    if (string.IsNullOrEmpty(ActivityName) || string.IsNullOrEmpty(Description))
    {
        RunActivity();
    }
    else
    {
        Console.Clear();
        RunActivity();
    }
}

    public Activity(string activityName, string description)
    {
        ActivityName = activityName;
        Description = description;
    }

    public Activity() { }


    // Function for getting the Duration in seconds from the user.
    public int GetDur()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string duration = Console.ReadLine();
        return Convert.ToInt32(duration);
    }

    public virtual void RunActivity()
    {
    }

    // Timer function for the loading icon.
    public void Timer()
    {
        for (var i = 0; i < 10; i++)
        {
            Turn();
            Thread.Sleep(500);
        }
        ClearCurrentConsoleLine();
    }

    public static void ClearCurrentConsoleLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    }

    // Function for displaying the timing icon.
    public void Turn()
    {
        _counter++;
        switch (_counter % 4)
        {
            case 0:
                Console.Write("/");
                break;
            case 1:
                Console.Write("-");
                break;
            case 2:
                Console.Write("\\");
                break;
            case 3:
                Console.Write("|");
                break;
        }
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }
}