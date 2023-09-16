using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade? ");
        string result = Console.ReadLine();
        int number = int.Parse(result);

        string grade = ""; 

        if (number >= 90)
        {   
            //Console.WriteLine("You got an A grade");
            grade = "A";
        }
        else if (number >= 80)
        {
            //Console.WriteLine("You got an B grade");
            grade = "B";
        }
        else if (number >= 70)
        {
            //Console.WriteLine("You got an C grade");
            grade = "C";
        }
        else if (number >= 60)
        {
            //Console.WriteLine("You got an D grade");
            grade = "D";
        }
        else (number < 60)
        {
            //Console.WriteLine("You got an F grade");
            grade = "F";
        }
        
        Console.WriteLine($"You got {grade} grade")

        if (number >= 70)
        {
            Console.WriteLine("Congratulations you have passed the class");
        }
        else
        {
            Console.WriteLine("unfortunaltely you did not meet the requirements but with more effort you can do it");
        }
    }
}    