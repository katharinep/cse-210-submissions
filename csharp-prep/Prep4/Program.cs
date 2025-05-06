using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");//

        List<int> numbers = new List<int>();

        bool notZero = true;

        while (notZero == true)
        {
            //Ask for list of numbers.
            Console.WriteLine("Enter number for the list. Enter 0 when done.");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //Console.WriteLine("You entered " + number);//

            numbers.Add(number);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            if (number == 0)
            {
                notZero = false;
            }
        }
        Console.WriteLine("Loop ended.");
        
    }
}