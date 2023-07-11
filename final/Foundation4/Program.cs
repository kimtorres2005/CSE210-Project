using System;

class Program
{
    static void Main(string[] args)
    {
        // Activities list
        Activity[] activities = {
            new Running(60, "1 Feb 2023", 3),
            new Running(60, "2 Feb 2023", 6),
            new Cycling(60, "1 Feb 2023", 3),
            new Cycling(60, "2 Feb 2023", 6),
            new Swimming(60, "1 Feb 2023", 16),
            new Swimming(60, "2 Feb 2023", 32)
        };

        // Getting the summary for each activity 
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}