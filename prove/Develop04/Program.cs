using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the mindfulness program!");
        bool _runPro = true;

        while (_runPro)
        {
            MainMenu();
            string _choice = Console.ReadLine();
            Console.Clear();

            if (_choice == "1")
            {
                // Breathing activity.
                Console.Clear();
                Activity _breathing = new BreathingActivity();
                _breathing.Introduction();
                Console.Clear();
            }
            else if (_choice == "2")
            {
                // Reflecting activity.
                Console.Clear();
                Activity _reflecting = new ReflectingActivity();
                _reflecting.Introduction();
                Console.Clear();
            }
            else if (_choice == "3")
            {
                // Listing activity.
                Console.Clear();
                Activity _listing = new ListingActivity();
                _listing.Introduction();
                Console.Clear();
            }
            else if (_choice == "4")
            {
                Log.DisplayLog();
                Console.WriteLine();
            }
            else if (_choice == "5")
            {
                Log.ClearLog();
                Console.WriteLine();
            }
            else if (_choice == "6")
            {
                _runPro = false;
            }
            else
            {
                Console.WriteLine("Try Again.");
            }
        }
    }

    public static void MainMenu()
    {
        Console.WriteLine("Please enter the numeric option below for the activity you would like to do:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Display Log");
        Console.WriteLine("5. Clear Log");
        Console.WriteLine("6. Quit Program");
        Console.Write("Enter your option: ");
    }

}