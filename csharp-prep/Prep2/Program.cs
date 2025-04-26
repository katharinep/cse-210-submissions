using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        //grade prompt//
        Console.WriteLine("What is the grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        //Console.WriteLine(grade);//

        //grade conditionals//
        string letter = "";

        if (grade >= 90)
        {
            letter = "an A";
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = "a B";

        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "a C.";

        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "a D";
        }
        else
        {
            letter = "an F";
        }

        //+ and - conditionals//
        int lastDigit = grade % 10;
        string plusMinus = "";

        if (lastDigit >= 7)
        {
            plusMinus = "+";
        }
        else if (lastDigit < 3)
        {
            plusMinus = "-";
        }

        //conditionals for As and Fs//
        
        
        //grade statement//
        Console.WriteLine($"Your grade is {letter}{plusMinus}.");

        //pass conditionals//
        if (grade >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You failed the class. :(");
        }

        //Source of how to get the last digit of a number: https://stackoverflow.com/questions/15731716/how-to-get-the-last-digit-of-a-number//
    }
}