using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Goal Tracker");
        int userPoints = 0;
        bool quit = false;
        List<Goal> goals = new List<Goal>();

        while (quit == false)
        {
            Console.WriteLine($"You have {userPoints} points");
            Menu menu = new Menu();
            menu.ShowMenu();
            string input = Console.ReadLine();
            int menuChoice = int.Parse(input);

            if (menuChoice >= 1 && menuChoice <= 6)
            {
                if (menuChoice == 1)
                {
                    menu.ShowGoals();
                    string userinput = Console.ReadLine();
                    int goalchoice = int.Parse(userinput);

                    if (goalchoice >= 1 && goalchoice <= 3)
                    {
                        if (goalchoice == 1)
                        {
                            //simple
                        }
                        if (goalchoice == 2)
                        {
                            //eternal
                        }
                        if (goalchoice == 3)
                        {
                            //checklist
                        }
                    }
                    else
                    {
                        quit = false;
                    }
                }
                else if (menuChoice == 2)
                {
                    foreach (Goal g in goals)
                    {
                        g.DisplayGoal();
                    }
                }
                else if (menuChoice == 3)
                {
                    SaveLoad save = new SaveLoad();
                    save.SaveFile();
                }
                else if (menuChoice == 4)
                {
                    SaveLoad load = new SaveLoad();
                    load.LoadFile();
                }
                else if (menuChoice == 5)
                {
                    //Record Event
                }
                else
                {
                    Console.WriteLine("See you next time!");
                    quit = true;
                }
            }
            else
            {
                Console.WriteLine("Please choose an option between 1 and 6");
                quit = false;
            }
        }
    }
}