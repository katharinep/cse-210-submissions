using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");//

        Console.WriteLine("Welcome to Journal Keeper");

        bool quit = false;

        while (quit == false)
        {
            //Display Menu//
            Console.WriteLine("Please choose one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("> ");

            string userInput = Console.ReadLine();
            int userChoice = int.Parse(userInput);

            //Error handling//
            if (userChoice >= 1 & userChoice <= 5)
            {
                //Menu conditionals//
                if (userChoice == 1)
                {

                }
                else if (userChoice == 2)
                {
                
                }
                else if (userChoice == 3)
                {
                
                }
                else if (userChoice == 4)
                {
                
                }
                else
                {
                    Console.WriteLine("See you later!");
                    quit = true;  
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Please choose a valid number.");
                Console.WriteLine("");

                quit = false;
            }

        }

    }

}