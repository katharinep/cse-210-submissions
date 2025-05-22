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

}