using System;

class ListingActivity : Activity
{

    // Print the introduction and get the duration from the user.
    int _duration;
    public override void Introduction()
    {
        Console.WriteLine("Welcome to the Listing Activity.\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _duration = GetDur();
        RunActivity();
    }

    // Function for running the activity.
    public override void RunActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Timer();

        // Question prompts.
        string[] _prompts = {
            " --- Who are people that you appreciate? ---\n",
            " --- What are personal strengths of yours? ---\n",
            " --- Who are people that you have helped this week? ---\n",
            " --- When have you felt the Holy Ghost this month? ---\n",
            " --- Who are some of your personal heroes? ---\n"
        };

        // Choosing a random prompt.
        Random _random = new Random();
        int _rand = _random.Next(0, _prompts.Length);

        // Start of the activity.
        Console.WriteLine("\nList as many responses as you can to the following prompt:\n");
        Console.WriteLine(_prompts[_rand]);

        Console.Write("You may begin in:  ");
        for (int k = 5; k > 0; k--)
        {
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write(Convert.ToString(k));
            Thread.Sleep(1000);
        }

        // Countdown and timing for.
        Console.WriteLine();
        DateTime _startTime = DateTime.Now;
        DateTime _futureTime = _startTime.AddSeconds(_duration);

        DateTime _currentTime = DateTime.Now;

        int _numberItems = 0;

        // Getting responses from user while time is still left.
        while (_currentTime < _futureTime)
        {
            _currentTime = DateTime.Now;
            Console.Write("> ");
            Console.ReadLine();
            _numberItems += 1;
        }

        // Displaying the results to the user.
        Console.WriteLine("\nYou listed " + _numberItems + " items!");
        Console.WriteLine("\nWell done!");
        Console.WriteLine("\nYou have completed " + _duration + " seconds of the Reflecting Activity.");
        Log.AppendLog("Listing Activity", _duration, _numberItems);
        Timer();
        Console.Clear();
    }
}