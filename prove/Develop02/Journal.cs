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
            //write formatting for displaying entries to console.//
        }
    }

    public string ExportEntry(string date, string prompt, string entry)
    {
        string fullEntry = date + "- Prompt: " + prompt + entry;
        return fullEntry;
    }
}