public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private bool _goalComplete;
    private List<string> _goals;

    public Goal()
    {

    }

    public virtual void GetEvent()
    {

    }

    public virtual int GetPoints()
    {
        return 0;
    }

    public virtual void DisplayScore()
    {

    }

    public virtual void DisplayGoals()
    {

    }

    public virtual string CreateGoal()
    {
        return "";
    }

    public virtual void RecordEvent()
    {

    }
}