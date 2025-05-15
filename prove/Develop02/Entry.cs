public class Entry
{
    public string _entry;
    public string _prompt;
    public string _date;

    //constructor//
    public Entry()
    {
        
    }

    //Methods//

    public void DisplayPrompt()
    {
        Prompt prompts = new Prompt();

        string prompt = prompts.GeneratePrompt();
        Console.WriteLine(prompt);
    }
    
    public string EntryInput()
    {
        _entry = Console.ReadLine();
        return _entry;
    }

    public string GenerateDate()
    {
        DateTime currentTime = DateTime.Now;
        string _date = currentTime.ToShortDateString();
        return _date;
    }
}