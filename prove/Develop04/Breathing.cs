class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        ActivityName = "Breathing Activity";
        Description = "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.\n";
    }

    // Print the Introduction for the activity and get the duration from the user.
    public override void Introduction()
    {
        Console.WriteLine($"Welcome to the {ActivityName}.\n");
        Console.WriteLine(Description);
        Duration = GetDur();
        Console.WriteLine("Starting the Breathing Activity...");
        Thread.Sleep(2000); // Pause for 2 seconds
        Console.Clear();
        RunActivity();
    }

    // Function for running the activity.
    public override void RunActivity()
    {
        // Setup for the activity.
        float _breathingInterval = 0;
        float _remainderInterval = 0;

        if (Duration <= 10)
        {
            _breathingInterval = Duration / 2;
        }
        else
        {
            _breathingInterval = 5;
            _remainderInterval = Duration % _breathingInterval;
        }

        // Prompt messages
        Console.Clear();
        Console.WriteLine("Get ready...");
        Timer();

        Console.WriteLine();

        // Breathing cycle loops.
        if (_remainderInterval == 0)
        {
            // If Duration is even.
            for (int i = (int)Math.Floor(Duration / _breathingInterval) / 2; i > 0; i--)
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
            // If Duration is uneven and there is a remainder interval that has to be smaller.
            for (int i = (int)Math.Floor(Duration / _breathingInterval) / 2; i > 0; i--)
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
        Console.WriteLine("\nYou have completed " + Duration + " seconds of the Breathing Activity.");
        Console.WriteLine("Ending the Breathing Activity...");
        Thread.Sleep(2000); // Pause for 2 seconds
        Timer();
        Console.Clear();
    }
}