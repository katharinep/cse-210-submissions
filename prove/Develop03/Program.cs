using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memory!\n\n");

        bool memory = true;
        while (memory == true)
        {
            Reference reference = Reference.RandomScripture();
            Scripture scripture = new Scripture(reference);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetRenderedText());

                if (scripture.AllHidden())
                {
                    break;
                }

                Console.WriteLine("\nPress enter to continue or press 'q' to quit.\n");
                string userinput = Console.ReadLine();

                if (userinput.Trim().ToLower() == "q")
                {
                    break;
                }

                scripture.HideWords();
            }

            Console.WriteLine("\nWould you like to try another scripture? (y/n)\n");

            string input = Console.ReadLine();
            if (input.Trim().ToLower() != "y")
            {
                break;
            }
        }
    }

    public void ClearScreen()
    {
        Console.Clear();
    }
}