using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int note = int.Parse(userInput);

        string grade = "";

        if (note >= 90)
        {
            grade = "A";
        }

        else if (note >= 80)
        {
            grade = "B";
        }

        else if (note >= 70)
        {
            grade = "C";
        }

        else if (note >= 60)
        {
            grade = "D";
        }

        else 
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        if (note >= 70)
        {
            Console.WriteLine("Congrats! You pass the semester!");
        }
        
        else
        {
            Console.WriteLine("Sorry, you don't pass the semester, but we will hope that you don't give up and try again!");
        }
    }
}