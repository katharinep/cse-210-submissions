public class Entry
{
    public string _entry;
    public string _prompt;
    public string _date;

    //constructor//
    public Entry(string entry, string prompt, string date)
    {
        _entry = entry;
        _prompt = prompt;
        _date = date;
    }

    //Methods//

    public void DisplayPrompt(string Prompt.randomPrompt)
    {

    }
    public string EntryInput(string _entry)
    {
        _entry = Console.ReadLine();
        return _entry;
    }
}