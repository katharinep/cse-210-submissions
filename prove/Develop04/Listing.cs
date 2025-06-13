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
        //finish writing this method
    }
}