using System.Collections.Generic;
public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    //Create Entries//
    public void AddEntry(Entry fullEntry)
    {
        entries.Add(fullEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {

             Console.WriteLine($"{entry._date} - Prompt: {entry._prompt} {entry._entry}");
            Console.WriteLine("");
        }
    }

    public string ExportEntry(string date, string prompt, string entry)
    {
        string fullEntry = date + "- Prompt: " + prompt + entry;
        return fullEntry;
    }
}