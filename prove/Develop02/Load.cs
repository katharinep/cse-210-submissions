using System;
using System.IO;
using System.Collections.Generic;
public class Load
{
    public string _fileName;

    //Constructor//
    public Load()
    {
    
    }

    //Methods//
    
    public static List<Entry> ReadFile(string filename)
    {
        List<Entry> entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Console.WriteLine(line);
        }
        return entries;
    }
}