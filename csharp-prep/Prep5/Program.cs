using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");//

        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        //SquareNumber(favNum);//
        //DisplayResult(userName, favNum);//

        static void DisplayWelcome()
        {
            Console.WriteLine("Welocome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            string userInput = Console.ReadLine();
            int favNum = int.Parse(userInput);
            return favNum;
        }

        static int SquareNumber(int favNum)
        {
            int squareNum = favNum * favNum;
            return squareNum;
        }
        
        static void DisplayResult(string userName, int squareNum)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareNum}");
        }
    }
}