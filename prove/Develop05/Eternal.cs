public class Eternal : Goal
{
    public Eternal() : base()
    {

    }

    public override void CreateGoal()
    {
        GetName();
        GetDescription();
        GetPoints();
    }

    public override int RecordEvent(ref int userPoints)
    {
        userPoints += _goalPoints;
        return userPoints;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_goalName} - {_goalDescription}");
    }

    public override string ToCsv()
    {
        return $"Eternal|{_goalName}|{_goalDescription}|{_goalPoints}";
    }

    public static Eternal FromCsv(string[] parts)
    {
        return new Eternal
        {
            _goalName = parts[1],
            _goalDescription = parts[2],
            _goalPoints = int.Parse(parts[3]),
        };
    }
}