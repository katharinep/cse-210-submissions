using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");//

        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2001;
        job1._endYear = 2008;

        //job1.Display();//

        Job job2 = new Job();

        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //job2.Display();//

        Resume resume = new Resume();
        resume._name = "Allison Rose";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}