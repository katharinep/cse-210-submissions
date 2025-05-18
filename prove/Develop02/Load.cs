using System;
using System.IO;
public class Load
{
    public string _fileName;

    //Constructor//
    public Load(string filename)
    {
        _fileName = filename;
    }

    //Methods//
    public string FilePrompt()
    {
        Console.Write("Enter file to load: ");
        _fileName = Console.ReadLine();
        return _fileName;
    }

    public string ReadFile(string _fileName)
    {
        string fullEntry = "";
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            fullEntry = date + "- Prompt: " + prompt + entry;
        }
        return fullEntry;
    }
}