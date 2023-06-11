using System.IO;

class Activity
{
    private int _counter;

    // Introduction function for each activity.
    public virtual void Introduction()
    {
    }

    // Function for getting the _duration in seconds from the user.
    public int GetDur()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string _duration = Console.ReadLine();
        return Convert.ToInt32(_duration);
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
        int _currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, _currentLineCursor);
    }

    // Function for displaying the timimg icon.
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