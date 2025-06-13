public class Reflection : Activity
{
    private string _randomPrompt;
    private string _randomQ;
    private List<string> _prompt = new List<string> {
       "Think of a time when you stood up for someone else.",
       "Think of a time when you did something really difficult.",
       "Think of a time when you helped someone in need.",
       "Think of a time when you did something truly selfless."
    };
    private List<string> _question = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection() : base()
    {

    }

    //getters and setters

    //Methods
    public string GetRandomPrompt()
    {
        Random randomp = new Random();
        int index = randomp.Next(_prompt.Count);
        string _randomPrompt = _prompt[index];
        return _randomPrompt;
    }

    public string GetRandomQ()
    {
        Random randomq = new Random();
        int index = randomq.Next(_question.Count);
        string _randomQ = _question[index];
        return _randomQ;
    }

    public void RunReflection(int duration)
    {
        _randomPrompt = GetRandomPrompt();
        ClearScreen();
        Console.CursorVisible = false;
        Console.WriteLine("Get ready...");
        Spinner();
        ClearScreen();

        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"--- {_randomPrompt} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Ponder each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Countdown();
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string _randomQ = GetRandomQ();
            Console.CursorVisible = true;
            Console.Write(">" + _randomQ);
            Spinner();
            Spinner();
            Console.WriteLine("");
        }

        Thread.Sleep(1000);
        EndingMessage();
        Thread.Sleep(2000);
        ClearScreen();
    }
}