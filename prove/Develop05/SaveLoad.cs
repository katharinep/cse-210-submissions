public class SaveLoad
{
    private string _userFile;

    public SaveLoad()
    {

    }

    public string GetFile()
    {
        Console.WriteLine("What is the name of your file (.csv)?");
        _userFile = Console.ReadLine();
        return _userFile;
    }
    public void SaveFile(string _userFile, List<Goal> goals)
    {
        using (StreamWriter writer = new StreamWriter(_userFile))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.ToCsv());
            }
        }
    }

    public List<Goal> LoadFile(string _userFile)
    {
        List<Goal> goals = new List<Goal>();

        using (StreamReader read = new StreamReader(_userFile))
        {
            string line;
            while ((line = read.ReadLine()) != null)
            {
                string[] parts = line.Split("|");
                string type = parts[0];

                if (type == "Simple")
                {
                    Simple g = Simple.FromCsv(parts);
                }
                if (type == "Eternal")
                {
                    Eternal g = Eternal.FromCsv(parts);
                }
                if (type == "Checklist")
                {
                    Checklist g = Checklist.FromCsv(parts);
                }

            }

        }

        return goals;
    }
}