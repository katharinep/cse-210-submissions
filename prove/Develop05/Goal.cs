public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;

    public Goal()
    {
        string name = _goalName;
        string description = _goalDescription;
        int points = _goalPoints;
    }

    public virtual string GetName()
    {
        Console.WriteLine("What is the name of the goal?");
        _goalName = Console.ReadLine();
        return _goalName;
    }

    public virtual string GetDescription()
    {
        Console.WriteLine("What is a description of the goal?");
        _goalDescription = Console.ReadLine();
        return _goalDescription;
    }

    public virtual int GetPoints()
    {
        Console.Write("How many points is the goal worth? ");
        string input = Console.ReadLine();
        _goalPoints = int.Parse(input);
        return _goalPoints;
    }

    public abstract string ToCsv();
    
    public abstract void CreateGoal();

    public abstract void RecordEvent(ref int userPoints);

    public abstract void DisplayGoal();
}