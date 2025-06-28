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
            Console.WriteLine("{ }" + $" {_goalName} - {_goalDescription}");
        }
        else
        {
            Console.WriteLine("{ }" + $" {_goalName} - {_goalDescription}");
        }
    }
}