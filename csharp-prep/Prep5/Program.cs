using System;

class Program
{
    
    static void Main(string[] args)
    {
        DisplayPersonalMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquaredNumber(number);
        DisplayResult(name, squaredNumber);
    }
    static void DisplayPersonalMessage()
    {
        Console.Write("Welcome to the Program!\n");
    }
    
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int inputNumber = int.Parse(userInput);

        return inputNumber;
    }
    private static int SquaredNumber(int number)
    {
        int storeSquaredNumber = number * number;
        return storeSquaredNumber;
    }
    
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}