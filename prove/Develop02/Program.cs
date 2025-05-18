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
                string fullEntry = "";
                //Menu conditionals//
                if (userChoice == 1)
                {
                    Entry journalentry = new Entry();
                    string prompt = journalentry.DisplayPrompt();
                    string entry = journalentry.EntryInput();
                    string date = journalentry.GenerateDate();
                    fullEntry = journalentry.ExportEntry(date, prompt, entry);
                }
                else if (userChoice == 2)
                {

                }
                else if (userChoice == 3)
                {
                    //load//
                    Console.Write("Enter the name of the file to load (.csv): ");
                    string fileName = Console.ReadLine();
                    Load loadFile = new Load(fileName);
                    loadFile.ReadFile(fileName);
                }
                else if (userChoice == 4)
                {
                    //save//
                    Console.Write("Enter the name of the file to save to (.csv): ");
                    string fileName = Console.ReadLine();
                    Save saveFile = new Save(fileName);
                    saveFile.WriteFile(fullEntry);

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