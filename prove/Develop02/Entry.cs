using System;
public class Entry
{
    public string _entry;
    public string _prompt;
    public string _date;

    //constructor//
    public Entry()
    {
        
    }

    public Entry(string prompt, string entry, string date)
    {
        _prompt = prompt;
        _entry = entry;
        _date = date;
    }

    //Methods//

    public string DisplayPrompt()
    {
        Prompt prompts = new Prompt();

        string prompt = prompts.GeneratePrompt();
        Console.WriteLine(prompt);
        return prompt;
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

    //full entry to add to entry list//
    //public string CreateFullEntry(string date, string prompt, string entry)
    //{
        //string fullEntry = 
    //}
}