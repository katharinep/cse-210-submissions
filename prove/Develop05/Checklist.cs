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

    public override void RecordEvent(ref int userPoints)
    {
        //single portion of the goal completed
    }
    
    public override void DisplayGoal()
    {
        throw new NotImplementedException();
    }
}