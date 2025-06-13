public class Breathing : Activity
{
    public Breathing() : base()
    {
        GetDuration();
    }

    //Getters and Setters

    //Methods

    public void RunBreathing(int duration)
    {
        Console.CursorVisible = false;
        ClearScreen();
        Console.WriteLine("Get ready...");
        Spinner();
        Console.WriteLine("");
        Console.WriteLine("");
        BreathingMessage(duration);
        Thread.Sleep(1000);
        EndingMessage();
        Thread.Sleep(2000);
        ClearScreen();
        Console.CursorVisible = true;
    }

    public void BreathingMessage(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            Countdown();
            Console.WriteLine("");
            Console.Write("Now breathe out...");
            Countdown();
            Console.WriteLine("");
            Console.WriteLine("");
        }

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
}