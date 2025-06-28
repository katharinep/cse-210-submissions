public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected string _goalPoints;
    protected bool _goalComplete;
    private List<Goal> _goals;

    public Goal()
    {
        _goals = new List<Goal>();
    }

    public virtual string GetName()
    {
        Console.WriteLine("What is the name of the goal?");
        string _goalName = Console.ReadLine();
        return _goalName;
    }

    public virtual string GetDescription()
    {
        Console.WriteLine("What is a description of the goal?");
        string _goalDescription = Console.ReadLine();
        return _goalDescription; 
    }

    public virtual int GetPoints()
    {
        string input = Console.ReadLine();
        int _goalPoints = int.Parse(input);
        return _goalPoints;
    }

    public virtual void DisplayScore()
    {

    }
    }

    public virtual void DisplayGoals()
    {

    }

    public virtual void CreateGoal()
    {
        this.GetName();
        this.GetDescription();
        this.GetPoints();
           
    }

    public virtual void RecordEvent()
    {

    }
}