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
        //run activity here
        string _randomPrompt = "";
        string _randomQ = "";

        GetRandomPrompt();
        GetRandomQ();
        Console.WriteLine(_randomPrompt);
        Console.WriteLine(_randomQ);
        Thread.Sleep(5000);
        
    }
}