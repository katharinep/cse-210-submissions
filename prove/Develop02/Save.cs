using System;
using System.Collections.Generic;
using System.IO;
public class Save
{
    public string _fileName;

    //Constructor//
    public Save(string filename)
    {
        _fileName = filename;
    }

    //Methods//

    public void WriteFile(List<Entry> entries)
    {
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in entries)
            {
                //date
                outputFile.WriteLine(entry._date);
                //prompt
                outputFile.WriteLine(entry._prompt);
                //entry
                outputFile.WriteLine(entry._entry);
            }
        }
    }
}