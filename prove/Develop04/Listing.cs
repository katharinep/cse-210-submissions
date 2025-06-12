public class Listing
{
    private int _entryCount;
    private string _randomPrompt;
    //check list syntax
    private List<string> Prompt = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public Listing()
    {
        
    }

    //Getters and Setters

    //Methods
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(Prompt.Count);
        string _randomPrompt = Prompt[index];
        return _randomPrompt;
    }

    public void RunListing()
    {
        //run listing activity here
        _entryCount = 0;
        //finish writing this method
    }
}