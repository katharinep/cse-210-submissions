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

    public override void RecordEvent()
    {
        
    }
}