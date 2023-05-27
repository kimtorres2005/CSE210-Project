using System;

class Program
{
    static void Main(string[] args)
    {
        Random _random = new Random();
        Reference _scriptureReference = new Reference("Psalm", 24, 3, 4);
        Scripture _scriptureMemorizer = new Scripture(_scriptureReference, @"Who shall ascend into the hill of" +
            " the Lord? or who shall stand in his holy place? He that hath clean hands, and a pure heart; who hath not lifted up his soul unto" +
            " vanity, nor sworn deceitfully.");

        string _userInput = "";

        Console.Clear();
        Console.WriteLine(_scriptureMemorizer.ToString());
        Console.WriteLine();
        Console.WriteLine("Press Enter to start or type 'quit' to exit.");
        _userInput = Console.ReadLine();

        if (_userInput != "quit")
        {
            int _numWordsToRemove = _random.Next(1, 5);
            while (_scriptureMemorizer.HasWordsLeft())
            {
                Console.Clear();
                Console.WriteLine(_scriptureMemorizer.ToString());
                Console.WriteLine();
                _userInput = Console.ReadLine();

                if (_userInput == "quit")
                    break;

                _scriptureMemorizer.HideRandomWords(_numWordsToRemove);
                _numWordsToRemove = _random.Next(1, 5);
            }

            if (_userInput != "quit")
            {
                Console.Clear();
                Console.WriteLine(_scriptureMemorizer.ToString());
                Console.WriteLine();
                Console.WriteLine("Congrats! You're a scripture master!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Better luck next time.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Better luck next time.");
            Console.WriteLine();
        }
    }
}
