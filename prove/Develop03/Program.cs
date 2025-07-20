using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memory!\n\n");
        
        bool memory = false;
        while (memory == false)
        {
            Reference reference = Reference.RandomScripture();
            Scripture scripture = new Scripture(reference);

        }
    }

    public void ClearScreen()
    {
        Console.Clear();
    }
}