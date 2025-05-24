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

            //string date = parts[0];
            //string prompt = parts[1];
            //string entry = parts[2];

            //fullEntry = date + "- Prompt: " + prompt + entry;
            Console.WriteLine(line);
        }
        return entries;
    }
}