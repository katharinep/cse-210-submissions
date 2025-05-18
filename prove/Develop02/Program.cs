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

            string userinput = Console.ReadLine();
            int userchoice = int.Parse(userinput);

            //Error handling//
            if (userchoice >= 1 & userchoice <= 5)
            {
                string fullentry = "";
                //Menu conditionals//
                if (userchoice == 1)
                {
                    Entry journalentry = new Entry();
                    string prompt = journalentry.DisplayPrompt();
                    string entry = journalentry.EntryInput();
                    string date = journalentry.GenerateDate();
                    fullentry = journalentry.ExportEntry(date, prompt, entry);
                }
                else if (userchoice == 2)
                {
                    //display//

                }
                else if (userchoice == 3)
                {
                    //load//
                    Console.Write("Enter the name of the file to load (.csv): ");
                    string filename = Console.ReadLine();
                    Load loadfile = new Load(filename);
                    loadfile.ReadFile(filename);
                }
                else if (userchoice == 4)
                {
                    //save//
                    Console.Write("Enter the name of the file to save to (.csv): ");
                    string filename = Console.ReadLine();
                    Save savefile = new Save(filename);
                    savefile.WriteFile(fullentry);

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