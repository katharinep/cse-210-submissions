using System;
using System.Collections.Generic;
public class Prompt
{
    public string _randomPrompt;
    public static List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    //Constructor//
    public Prompt()
    {

    }

    //Methods//
    public string GeneratePrompt()
    {
        Random random = new Random();
        int randomindex = random.Next(1, 5);
        _randomPrompt = _prompts[randomindex];
        return _randomPrompt;
    }
}