using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput)

        if (grade >= 90)
        {
            Console.WriteLine("A");
        }

        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }

        else if (grade >= 70)
        {
            Console.WriteLine("B");
        }

        else if (grade >= 60)
        {
            Console.WriteLine("B");
        }

        else 
        {
            Console.WriteLine("F");
        }
    }
}