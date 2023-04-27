using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int inputNumber;
        List<int> numbers = new List<int>();
        int sum = 0;
        double average;
        int largestNumber;
        int minPositiveNumber;
        List<int> sortNumbers = new List<int>();
        Console.Write("Enter a list of numbers, type 0 when finished.\n");
            do
            {
                Console.Write("Enter number: ");
                string userInput = Console.ReadLine();
                inputNumber = int.Parse(userInput);
                if (inputNumber != 0) 
                {
                    numbers.Add(inputNumber);
                }
                sum += inputNumber;
            } while (inputNumber != 0);
                minPositiveNumber = numbers.Where(x => x >= 0).Min();
                average = numbers.Average();
                largestNumber = numbers.Max();
                Console.WriteLine($"the sum is: {sum}");
                Console.WriteLine($"the average is: {average}");
                Console.WriteLine($"the largest number is: {largestNumber}");
                Console.WriteLine($"the smallest positive number is: {minPositiveNumber}");
                numbers.Sort();
                Console.WriteLine("The sorted list is:");
                for (int i = 0; i < numbers.Count; i++)
                {
                    int number = numbers[i];
                    Console.WriteLine(number);
                }
    }
}