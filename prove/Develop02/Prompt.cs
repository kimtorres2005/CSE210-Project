using System;
using System.IO;

public class Prompt
{
  // create prompts for each question
    public string [] _prompts=
    {
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "How did I see the hand of the Lord in my life today?",
        "If I could do one thing differently today what would it be?",
        "Who is the most interesting person I interacted with today?"
    };

    private Random _random = new Random();

    // get a random prompt from the list
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Length);
        return _prompts[index];
    }
}
