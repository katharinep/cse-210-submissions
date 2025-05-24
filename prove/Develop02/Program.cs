using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to Journal Keeper");
        Console.WriteLine("");

        bool quit = false;
        Journal journal = new Journal();
        Console.Write(" Please enter the filename you will be loading and saving to (.csv): ");
        string filename = Console.ReadLine();

        Console.WriteLine($"You chose to save to {filename}");
        Console.WriteLine("");

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
                    journal.DisplayEntries();

                }
                else if (userchoice == 3)
                {
                    //load//
                    List<Entry> loadJournal = Load.ReadFile(filename);

                    foreach (Entry e in loadJournal)
                    {
                        Console.WriteLine($"{e._date} - Prompt: {e._prompt} {e._entry}");
                        Console.WriteLine("");
                    }
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
//For extra credit I added a little error handling in case the user inputs an option that doesn't exist.//
//I also added confirmation for the user on which file they will be loading from or saving to. It's simple but should help the user.//