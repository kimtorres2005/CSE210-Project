class BreathingActivity : Activity
{

    // Print the Introduction for the activity and get the duration from the user.
    int _duration;
    public override void Introduction()
    {
        Console.WriteLine("Welcome to the Breathing Activity.\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.\n");
        _duration = GetDur();
        RunActivity();
    }

    // Function for running the activity.
    public override void RunActivity()
    {
        // Setup for the activity.
        float _breathingInterval = 0;
        float _remainderInterval = 0;

        if (_duration <= 10)
        {
            _breathingInterval = _duration / 2;
        }
        else
        {
            _breathingInterval = 5;
            _remainderInterval = _duration % _breathingInterval;
        }

        // Prompt messages
        Console.Clear();
        Console.WriteLine("Get ready...");
        Timer();

        Console.WriteLine();

        // Breathing cycle loops.
        if (_remainderInterval == 0)
        {
            // If _duration is even.
            for (int i = (int)Math.Floor(_duration / _breathingInterval) / 2; i > 0; i--)
            {
                Console.Write("Breathe in... ");
                for (int k = (int)Math.Floor(_breathingInterval); k > 0; k--)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(Convert.ToString(k));
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.Write("Breathe out... ");
                for (int k = (int)Math.Floor(_breathingInterval); k > 0; k--)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(Convert.ToString(k));
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }
        }
        else
        {
            // If _duration is uneven and there is a remainder interval that has to be smaller.
            for (int i = (int)Math.Floor(_duration / _breathingInterval) / 2; i > 0; i--)
            {
                Console.Write("Breathe in... ");
                for (int k = (int)Math.Floor(_breathingInterval); k > 0; k--)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(Convert.ToString(k));
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.Write("Breathe out... ");
                for (int k = (int)Math.Floor(_breathingInterval); k > 0; k--)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(Convert.ToString(k));
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }
            Console.Write("Breathe in... ");
            for (int k = (int)Math.Floor(_remainderInterval / 2); k > 0; k--)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write(Convert.ToString(k));
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            Console.Write("Breathe out... ");
            for (int k = (int)Math.Floor(_breathingInterval / 2); k > 0; k--)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write(Convert.ToString(k));
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        // Ending message.
        Console.WriteLine("\nWell done!");
        Console.WriteLine("\nYou have completed " + _duration + " seconds of the Breathing Activity.");
        Log.AppendLog("Breathing Activity", _duration);
        Timer();
        Console.Clear();
    }
}