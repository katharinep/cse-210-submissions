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
        if (grade >= 90)
        {
            Console.WriteLine("Your grade is an A.");
        }
        else if (grade < 90 && grade >= 80)
        {
            Console.WriteLine("Your grade is a B.");

        }
        else if (grade < 80 && grade >= 70)
        {
            Console.WriteLine("Your grade is a C.");

        }
        else if (grade < 70 && grade >= 60)
        {
            Console.WriteLine("Your grade is a D.");

        }
        else
        {
            Console.WriteLine("Your grade is an F.");
        }

        //pass conditionals//
        if (grade >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You failed the class. :(");
        }
    }
}