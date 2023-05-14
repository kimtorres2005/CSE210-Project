using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool run = true;
    
        while (run == true)
        {
            Console.WriteLine("1.Write 2.Display 3.Load 4.Save 5.Quit");
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                journal.PromptsUserToWrite();
            }
            else if(choice == "2")
            {
                journal.displayEntries();
            }
            else if(choice == "3")
            {
                journal.LoadEntriesFrom();
            }
            else if(choice == "4")
            {
                journal.SaveEntries();
            }
            else if(choice == "5")
            {
                Console.WriteLine("Thank you for your entry.");
                Console.WriteLine("See you tomorrow.");
                run = false;
            }
            else
            {
                Console.WriteLine("Please try Again.");
            }
         }
    }
}