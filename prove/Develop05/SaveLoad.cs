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
        return _userFile + ".csv";
    }
    public void SaveFile(string _userFile, List<Goal> goals, ref int userPoints)
    {
        using (StreamWriter writer = new StreamWriter(_userFile))
        {
            writer.WriteLine($"Points|{userPoints}");
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.ToCsv());
            }
        }
        //Console.WriteLine("Saving to: " + _userFile);
        //Console.WriteLine("Full path: " + Path.GetFullPath(_userFile));
    }

    public (List<Goal>, int) LoadFile(string _userFile)
    {
        List<Goal> goals = new List<Goal>();
        int userPoints = 0;
        using (StreamReader read = new StreamReader(_userFile))
        {
            string line;
            while ((line = read.ReadLine()) != null)
            {
                string[] parts = line.Split("|");
                string type = parts[0];


                if (type == "Points")
                {
                    userPoints = int.Parse(parts[1]);
                }
                else if (type == "Simple")
                {
                    goals.Add(Simple.FromCsv(parts));
                }
                else if (type == "Eternal")
                {
                    goals.Add(Eternal.FromCsv(parts));
                }
                else if (type == "Checklist")
                {
                    goals.Add(Checklist.FromCsv(parts));
                }
            }
        }

        return (goals, userPoints);
    }
}