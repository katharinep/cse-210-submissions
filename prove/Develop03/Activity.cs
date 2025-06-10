public class Activity
{
    private int _duration;
    private int _activityChoice;

    public Activity()
    {
        duration = _duration;
        activitychoice = _activityChoice;
    }

    //Getters and Setters
    public int GetDuration()
    {
        return _duration;
    }

    public int GetActivityChoice()
    {
        return _activityChoice;
    }

    public void SetDuration()
    {
        duration = _duration;
    }

    public void SetActivityChoice()
    {
        activitychoice = _activityChoice;
    }

    //Methods

    public void ActivityDescription(int _activityChoice)
    {
        //display activity instructions with conditional reasoning
    }

    public void ActivityTimer(int _duration)
    {
        //activity timer
    }

    public void EndingMessage()
    {
        //ending message
    }

    public void Spinner()
    {
        //display spinner animation
    }

    public void ClearScreen()
    {
        Console.Clear();
    }

}