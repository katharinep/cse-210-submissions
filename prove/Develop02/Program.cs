using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");//

        Console.WriteLine("Welcome to Journal Keeper");
        Console.WriteLine("");

        bool quit = false;
        Journal journal = new Journal();
        Console.Write(" Please enter the filename you will be loading and saving to: ");
        string filename = Console.ReadLine();

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
                //string fullentry = "";
                //Menu conditionals//
                if (userchoice == 1)
                {
                    Entry journalentry = new Entry();
                    journalentry._date = journalentry.GenerateDate();
                    journalentry._prompt = journalentry.DisplayPrompt();
                    journalentry._entry = journalentry.EntryInput();
                    journal.AddEntry(journalentry);
                    
                }
                else if (userchoice == 2)
                {
                    //display//

                }
                else if (userchoice == 3)
                {
                    //load//
                    Console.Write("Enter the name of the file to load (.csv): ");
                    //string filename = Console.ReadLine();//
                    Load loadfile = new Load(filename);
                    loadfile.ReadFile(filename);
                }
                else if (userchoice == 4)
                {
                    //save//
                    Save savefile = new Save(filename);
                    savefile.WriteFile(journal.entries);
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