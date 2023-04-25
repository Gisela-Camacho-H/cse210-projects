using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 51);
        Console.WriteLine(number);
        int count = 0;
        int guessNumber;
            do
            {
                count += 1;
                Console.Write("What is your guess? (1 - 50)? ");
                string userInput = Console.ReadLine();
                guessNumber = int.Parse(userInput);
                if (guessNumber >= 51)
                {
                    Console.WriteLine("The magic number is between 1 - 50");
                }
                else if (guessNumber > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < number)
                {
                    Console.WriteLine("Higher");
                } else if (guessNumber == number) {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Number or guesses: {count}");
                }
            } while (guessNumber != number);
    }
}