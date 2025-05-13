public class Prompt
{
    public string _randomPrompt;
    public static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    //Constructor//
    public Prompt(string randomprompt)
    {
        _randomPrompt = randomprompt;
    }

    //Methods//
    public string GeneratePrompt(List<string> prompts)
    {
        Random random = new Random();
        int randomindex = random.Next(1, 5);
        _randomPrompt = prompts[randomindex];
        return _randomPrompt;
    }
}