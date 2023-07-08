using System;

class Program3
{
    public static void Main(string[] args)
    {
        // Lecture event
        Console.WriteLine("Event 1 - Lecture\n");
        Lecture lectureEvent = new Lecture

        // Getting each description
        Console.WriteLine(lectureEvent.getShortDescription());
        Console.WriteLine(lectureEvent.getStandardDetails());
        Console.WriteLine(lectureEvent.getFullDetails());

        // Reception event
        Console.WriteLine("\nEvent 2 - Reception\n");
        Reception receptionEvent = new Reception("Reception", "Brenner and Emily's Wedding Reception",
        "Please come to Brenner and Emily's wedding reception to celebrate their marriage!", "8/25/2023",
        "3:00 PM", new Address("123 Idaho Falls Rd", "Idaho Falls", "ID", "United States"), "brenner98@gmail.com");

        // Getting each description
        Console.WriteLine(receptionEvent.getShortDescription());
        Console.WriteLine(receptionEvent.getStandardDetails());
        Console.WriteLine(receptionEvent.getFullDetails());

        // Outdoor gathering event
        Console.WriteLine("\nEvent 3 - Outdoor Gathering\n");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Outdoor Gathering", "Snowman Making",
        "Come to the BYU-I stadium field to help each other make snowmen!", "2/26/2023", "8:00 PM",
        new Address("239 S 1st W", "Rexburg", "ID", "United States"), "Snowing, 5 inches of snow expected");

        // Getting each description
        Console.WriteLine(outdoorEvent.getShortDescription());
        Console.WriteLine(outdoorEvent.getStandardDetails());
        Console.WriteLine(outdoorEvent.getFullDetails());
    }
}