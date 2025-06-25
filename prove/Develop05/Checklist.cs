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
        return false;
    }
}