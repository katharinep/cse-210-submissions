public class Activity
{
    private int _duration;
    private int _activityChoice;

    public Activity()
    {
        int duration = _duration;
        int activitychoice = _activityChoice;
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
        int duration = _duration;
    }

    public void SetActivityChoice()
    {
        int activitychoice = _activityChoice;
    }

    //Methods

    public void ActivityDescription(int _activityChoice)
    {
        if (_activityChoice == 1)
        {
            //breathing
            Console.WriteLine("Welcome to the Breathing Activity.");
            Console.WriteLine("In this activity you will be doing a session of deep breathing.");
            Console.WriteLine("You will be guided through this activity. Simply follow the directions.");
            Console.WriteLine("You may feel more peace and less stress through this exercies.");
        }
        if (_activityChoice == 2)
        {
            //reflection
            Console.WriteLine("Welcome to the Reflection Activity.");
            Console.WriteLine("In this activity you will be reflecting on a certain experience where you demonstrated strength.");
            Console.WriteLine("You will receive a prompt and questions to reflect more deeply.");
            Console.WriteLine("You may discover you have more depth than you realized.");
        }
        if (_activityChoice == 3)
        {
            //listing
            Console.WriteLine("Welcome to the Listing Activity.");
            Console.WriteLine("In this activity you will be listing as many things as you can about a certain area of strength or positivity.");
            Console.WriteLine("You may discover more about yourself than you previously realized.");
        }
    }

    public int ActivityLength()
    {
        Console.Write("How long in seconds would you like your session to be? ");
        int _userChoice = Console.Read();
        int _duration = _userChoice * 1000;
        return _duration;
    }
    public void ActivityTimer(int _duration)
    {
        //activity timer
    }

    public void EndingMessage()
    {
        //ending message
        Console.WriteLine("Well done! Have a great rest of your day!");
    }

    public void Spinner()
    {
        //display spinner animation
        Console.Write("|");
        Thread.Sleep(1000);

        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(1000);

        Console.Write("\b \b");
        Console.Write("\u2014");
        Thread.Sleep(1000);

        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(1000);

        Console.Write("\b \b");
    }

    public void ClearScreen()
    {
        Console.Clear();
    }

}