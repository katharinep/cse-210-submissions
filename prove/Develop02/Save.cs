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
    public string SavePrompt()
    {
        Console.Write("Enter name of file to save to: ");
        _fileName = Console.ReadLine();
        return _fileName;
    }

    public void WriteFile(string fullEntry)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(fullEntry);
        }
    }
}