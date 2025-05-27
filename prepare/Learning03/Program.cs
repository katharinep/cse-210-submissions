using System;

class Program
{
    static void Main(string[] args)
    {
        bool program = false;

        while (program == false)
        {
            Console.WriteLine("Fraction Calculator");
            Console.Write("Enter the top number: ");
            string userTop = Console.ReadLine();
            int top = int.Parse(userTop);

            Console.Write("Enter the bottom number: ");
            string userBottom = Console.ReadLine();
            int bottom = int.Parse(userBottom);

            if (bottom == 1)
            {
                Fraction wholeFraction = new Fraction(top);
                wholeFraction.SetTop(top);

                string fractionstring = wholeFraction.GetFractionString(top, bottom);
                Console.WriteLine(fractionstring);

                double decimalValue = wholeFraction.GetDecimalValue(top, bottom);
                Console.WriteLine(decimalValue);

            }
            else if (bottom == 1 & top == 1)
            {
                Fraction defaultOne = new Fraction();

                string fractionstring = defaultOne.GetFractionString(top, bottom);
                Console.WriteLine(fractionstring);

                double decimalValue = defaultOne.GetDecimalValue(top, bottom);
                Console.WriteLine(decimalValue);
            }
            else
            {
                Fraction fraction = new Fraction(top, bottom);
                fraction.SetTop(top);
                fraction.SetBottom(bottom);

                string fractionstring = fraction.GetFractionString(top, bottom);
                Console.WriteLine(fractionstring);

                double decimalValue = fraction.GetDecimalValue(top, bottom);
                Console.WriteLine(decimalValue);
            }

        }
    }
}