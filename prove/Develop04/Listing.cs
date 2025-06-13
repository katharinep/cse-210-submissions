public class Listing : Activity
{
    private int _entryCount;
    private string _randomPrompt;
    //check list syntax
    private List<string> _prompt = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public Listing() : base()
    {
        
    }

    //Getters and Setters

    //Methods
    public string GetRandomPrompt()
    {
        Random randomp = new Random();
        int index = randomp.Next(_prompt.Count);
        string _randomPrompt = _prompt[index];
        return _randomPrompt;
    }

    public void RunListing(int duration)
    {
        //run listing activity here
        _entryCount = 0;
        _randomPrompt = GetRandomPrompt();
        ClearScreen();
        Console.CursorVisible = false;
        Console.WriteLine("Get ready...");
        Spinner();
        ClearScreen();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_randomPrompt} ---");
        Console.Write("You may begin in: ");
        Countdown();
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _entryCount = _entryCount + 1;
        }
        Console.WriteLine("");
        Console.WriteLine($"You listed {_entryCount} items.");
        Thread.Sleep(1000);
        Console.CursorVisible = true;
        EndingMessage();
        Thread.Sleep(2000);
        ClearScreen();
    }
}