public class Breathing : Activity
{
    public Breathing(int _duration) : base()
    {

    }

    //Getters and Setters

    //Methods

    public void RunBreathing(int duration)
    {

    }

    public void BreathingMessage(int duration)
    {
        // breathe in breath out
    }

    public void Countdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write("i");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}