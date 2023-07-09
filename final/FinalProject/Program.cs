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
                Console.Write("1. Parent\n");
                Console.Write("2. Student\n");
                Console.Write("3. Secretary\n");
                Console.Write("4. Teacher\n");
                Console.Write("5. Quit\n");
                Console.WriteLine("");
                Console.Write("Select your Rol in the school: ");
                string userInput = Console.ReadLine();
                inputNumber = int.Parse(userInput);
                Console.WriteLine("");

                Console.Clear();
                if (inputNumber == 1){
                    Console.WriteLine("option 1");
                }
                else if (inputNumber == 2){
                    Console.WriteLine("option 2");
                }
                else if (inputNumber == 3){
                   Console.WriteLine("option 3");
                }
                else if (inputNumber == 4){
                   Console.WriteLine("option 4"); 
                }
            } while (inputNumber != 5);
            Console.Write("Good Bye\n");
    }
}