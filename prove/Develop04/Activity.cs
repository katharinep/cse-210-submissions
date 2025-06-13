public class Activity
{
    private int _duration;
    private int _activityChoice;

    public Activity()
    {

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

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void SetActivityChoice(int activitychoice)
    {
        _activityChoice = activitychoice;
    }

    //Methods

    public void ActivityDescription(int _activityChoice)
    {
        if (_activityChoice == 1)
        {
            //breathing
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Breathing Activity.");
            Console.WriteLine("");
            Console.WriteLine("In this activity you will be doing a session of deep breathing.");
            Console.WriteLine("You will be guided through this activity. Simply follow the directions.");
            Console.WriteLine("You may feel more peace and less stress through this exercies.");
            Console.WriteLine("");
        }
        if (_activityChoice == 2)
        {
            //reflection
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Reflection Activity.");
            Console.WriteLine("");
            Console.WriteLine("In this activity you will be reflecting on a certain experience where you demonstrated strength.");
            Console.WriteLine("You will receive a prompt and questions to reflect more deeply.");
            Console.WriteLine("You may discover you have more depth than you realized.");
            Console.WriteLine("");
        }
        if (_activityChoice == 3)
        {
            //listing
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Listing Activity.");
            Console.WriteLine("");
            Console.WriteLine("In this activity you will be listing as many things as you can about a certain area of strength or positivity.");
            Console.WriteLine("You may discover more about yourself than you previously realized.");
            Console.WriteLine("");
        }
    }

    public int ActivityLength()
    {
        Console.Write("How long in seconds would you like your session to be? ");
        string _userChoice = Console.ReadLine();
        int _duration = int.Parse(_userChoice);
        return _duration;
    }
    public void ActivityTimer(int _duration)
    {
        //activity timer
    }

    public void EndingMessage()
    {
        //ending message
        Console.WriteLine("Well done!");
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

    public void Countdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ClearScreen()
    {
        Console.Clear();
    }

}