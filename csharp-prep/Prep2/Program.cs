using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        if (grade >= 90 && grade <= 100)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        if (grade < 70)
        {
            Console.WriteLine("Sorry, you can try again next semester");
        } else {
            Console.WriteLine("Congratulations!!! you pass the course");
        }
    }
}