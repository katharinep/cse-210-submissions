using System;
//using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.CursorVisible = false;
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Welcome to my Mindfullness Program!");
        Console.WriteLine("");

        bool run = true;

        while (run == true)
        {
            DisplayMenu();
            string userinput = Console.ReadLine();
            int activitychoice = int.Parse(userinput);

            if (activitychoice == 1)
            {
                //breathing
                Breathing breathing = new Breathing();

                breathing.ActivityDescription(activitychoice);
                int duration = breathing.ActivityLength();
                breathing.RunBreathing(duration);
            }
            if (activitychoice == 2)
            {
                //reflection
            }
            if (activitychoice == 3)
            {
                //listing
            }
            if (activitychoice == 4)
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Please choose a number 1-4");
                run = true;
            }

        }

        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("See you next time!");
        Console.WriteLine(""); 

    }

    public static void DisplayMenu()
    {
        //menu//
        Console.WriteLine("Menu Options:");
        Console.WriteLine("");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflection activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("");
        Console.Write("Select a choice from the menu: ");
    }
}