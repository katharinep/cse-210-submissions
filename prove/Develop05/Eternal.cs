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

    public override void RecordEvent(ref int userPoints)
    {
        userPoints += _goalPoints;
    }
    
    public override void DisplayGoal()
    {
        Console.WriteLine("{ }" + $" {_goalName} - {_goalDescription}");
    }
}