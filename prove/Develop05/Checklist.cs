public class Checklist : Goal
{
    private int _finalPoints;
    private int _countGoal;
    private int _totalTasks;
    private bool _completeChecklist;

    public Checklist() : base()
    {

    }

    public bool CompleteTask()
    {
        //all parts of the goal completed and bonus rewarded
        return false;
    }

    public override void CreateGoal()
    {
        GetName();
        GetDescription();
        Console.WriteLine("How many times should this goal be completed?");
        string input = Console.ReadLine();
        int _countGoal = int.Parse(input);
        GetPoints();
        Console.WriteLine("How many bonus points for completing the goal?");
        string userinput = Console.ReadLine();
        int _finalPoints = int.Parse(userinput);
    }

    public override int RecordEvent(ref int userPoints)
    {
        //single portion of the goal completed
        return userPoints;
    }

    public override void DisplayGoal()
    {
        //write two conditionals for whether the goal is complete. Add progress to the uncompleted goal (e.g., 1/3)
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