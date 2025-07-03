public class Simple : Goal
{
    private bool _goalComplete;

    public Simple() : base()
    {

    }

    public override void CreateGoal()
    {
        GetName();
        GetDescription();
        GetPoints();
        _goalComplete = false;
    }

    public override void RecordEvent(ref int userPoints)
    {
        userPoints += _goalPoints;
        _goalComplete = true;
    }

    public override void DisplayGoal()
    {
        if (_goalComplete == false)
        {
            Console.WriteLine($"[ ] {_goalName} - {_goalDescription}");
        }
        else
        {
            Console.WriteLine($"[X] {_goalName} - {_goalDescription}");
        }
    }

    public override string ToCsv()
    {
        return $"Simple|{_goalName}|{_goalDescription}|{_goalPoints}|{_goalComplete}";
    }

    public static Simple FromCsv(string[] parts)
    {
        {
            Simple goal = new Simple();
            goal._goalName = parts[1];
            goal._goalDescription = parts[2];
            goal._goalPoints = int.Parse(parts[3]);
            goal._goalComplete = bool.Parse(parts[4]);

            return goal;
        }
    }
}