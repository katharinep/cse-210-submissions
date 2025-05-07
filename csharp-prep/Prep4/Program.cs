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
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //Console.WriteLine("You entered " + number);//

            if (number == 0)
            {
                notZero = false;
            }

            numbers.Add(number);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        //Console.WriteLine("Loop ended.");//

        numbers.Remove(0);
        
        int sum = numbers.Sum();
        Console.WriteLine("The sum is: " + sum);
        
        double average = sum / numbers.Count;
        Console.WriteLine("The average is: " + average);

        int largest = numbers.Max();
        Console.WriteLine("The largest number is: " + largest);

    }
}