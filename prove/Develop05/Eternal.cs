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
    
    public override void RecordEvent()
    {
        
    }
}