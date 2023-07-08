using System;

class Program3
{
    public static void Main(string[] args)
    {
        // Lecture event
        Console.WriteLine("Event 1 - Lecture\n");
        Lecture lectureEvent = new Lecture("Lecture", "Professor Thomas",
        "Lecture about programming with classes with Michael Thomas in the STC in room 243!",
        "8/12/2023", "5:00 PM", new Address("210 West 4th South", "Rexburg", "ID", "United States"),
        "Michael Thomas", 100);

        // Getting each description
        Console.WriteLine(lectureEvent.getShortDescription());
        Console.WriteLine(lectureEvent.getStandardDetails());
        Console.WriteLine(lectureEvent.getFullDetails());

        // Reception event
        Console.WriteLine("\nEvent 2 - Reception\n");
        Reception receptionEvent = new Reception("Reception", "Brandon and Ashley's Wedding Reception",
        "Please come to Brandon and Ashley's wedding reception to celebrate their marriage!", "9/23/2023",
        "4:00 PM", new Address("321 Idaho Falls Rd", "Idaho Falls", "ID", "United States"), "brandon97@gmail.com");

        // Getting each description
        Console.WriteLine(receptionEvent.getShortDescription());
        Console.WriteLine(receptionEvent.getStandardDetails());
        Console.WriteLine(receptionEvent.getFullDetails());

        // Outdoor gathering event
        Console.WriteLine("\nEvent 3 - Outdoor Gathering\n");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Outdoor Gathering", "Snowman Making",
        "Come to the BYU-I stadium field to help each other make snowmen!", "1/26/2024", "8:00 PM",
        new Address("239 S 1st W", "Rexburg", "ID", "United States"), "Snowing, 5 inches of snow expected");

        // Getting each description
        Console.WriteLine(outdoorEvent.getShortDescription());
        Console.WriteLine(outdoorEvent.getStandardDetails());
        Console.WriteLine(outdoorEvent.getFullDetails());
    }
}