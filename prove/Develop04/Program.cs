using System;

class Program
{
    static void Main(string[] args)
    {
        int inputNumber;
            do
            {
                Console.WriteLine("");
                Console.Write("Menu Option:\n");
                Console.WriteLine("");
                Console.Write("1. Start breathing activity\n");
                Console.Write("2. Start reflection activity\n");
                Console.Write("3. Start listing activity\n");
                Console.Write("4. Quit\n");
                Console.WriteLine("");
                Console.Write("Select a choice from the menu: ");
                string userInput = Console.ReadLine();
                inputNumber = int.Parse(userInput);
                Console.WriteLine("");

                if (inputNumber == 1)
                {
                    Console.WriteLine("option 1");
                }
                else if (inputNumber == 2)
                {
                    Console.WriteLine("option 2");  
                }
                else if (inputNumber == 3)
                {
                    Console.WriteLine("option 3");  
                } 
 
            } while (inputNumber != 4);
            Console.Write("Good Bye\n");
    }
}