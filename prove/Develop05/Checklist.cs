public class Checklist : Goal
{
    private int _finalPoints;
    private int _countGoal; //total times to complete the goal for bonus points
    private int _totalTasks; //goals completed so far
    private bool _completeChecklist;

    public Checklist() : base()
    {
        _completeChecklist = false;
    }

    public override void CreateGoal()
    {
        GetName();

        GetDescription();

        Console.WriteLine("How many times should this goal be completed?");
        string input = Console.ReadLine();
        _countGoal = int.Parse(input);

        GetPoints();

        Console.WriteLine("How many bonus points for completing the goal?");
        string userinput = Console.ReadLine();
        _finalPoints = int.Parse(userinput);
    }

    public override int RecordEvent(ref int userPoints)
    {
        _totalTasks++;
        userPoints += _goalPoints;

        if (_totalTasks >= _countGoal)
        {
            _completeChecklist = true;
            userPoints += _finalPoints;
        }
        return userPoints;
    }

    public override void DisplayGoal()
    {
        if (_completeChecklist == true)
        {
            Console.WriteLine($"[X] {_goalName} - {_goalDescription} completed {_totalTasks}/{_countGoal}");
        }
        else
        {
            Console.WriteLine($"[ ] {_goalName} - {_goalDescription} completed {_totalTasks}/{_countGoal}");
        }
    }


    //indexes:
    // 0 = Checklist
    // 1 = _goalName
    // 2 = _goalDescription
    // 3 = _goalPoints
    // 4 = _totalTasks
    // 5 = _countGoal
    // 6 = _finalPoints
    // 7 = _completeChecklist
    public override string ToCsv()
    {
        return $"Checklist|{_goalName}|{_goalDescription}|{_goalPoints}|{_totalTasks}|{_countGoal}|{_finalPoints}|{_completeChecklist}";
    }

    public static Checklist FromCsv(string[] parts)
    {
        return new Checklist
        {
            _goalName = parts[1],
            _goalDescription = parts[2],
            _goalPoints = int.Parse(parts[3]),
            _totalTasks = int.Parse(parts[4]),
            _countGoal = int.Parse(parts[5]),
            _finalPoints = int.Parse(parts[6]),
            _completeChecklist = bool.Parse(parts[7]),
        };
    }
}