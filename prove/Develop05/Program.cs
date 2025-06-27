using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Goal Tracker");
        int userPoints = 0;
        bool quit = false;

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
                    //New Goal
                }
                else if (menuChoice == 2)
                {
                    //List Goal
                }
                else if (menuChoice == 3)
                {
                    //Save Goal
                }
                else if (menuChoice == 4)
                {
                    //Load Goal
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