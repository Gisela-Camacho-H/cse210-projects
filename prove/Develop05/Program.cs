using System;

class Program
{
    static void Main(string[] args)
    {
        int inputNumber;
        int points;
            do
            {
                Console.WriteLine("");
                Console.Write("Menu Option:\n");
                Console.WriteLine("");
                Console.Write("1. Create New Goal\n");
                Console.Write("2. List Goals\n");
                Console.Write("3. Save Goals\n");
                Console.Write("4. Load Goals\n");
                Console.Write("5. Record Event\n");
                Console.Write("6. Quit\n");
                Console.WriteLine("");
                Console.Write("Select a choice from the menu: ");
                string userInput = Console.ReadLine();
                inputNumber = int.Parse(userInput);
                Console.WriteLine("");

                Console.Clear();
                if (inputNumber == 1){
                    Console.Write("New Goal\n");
                }
                else if (inputNumber == 2){
                    Console.Write("List\n");
                }
                else if (inputNumber == 3){    
                    Console.Write("Save\n");       
                }
                else if (inputNumber == 4){
                    Console.Write("Load\n");
                }
                else if (inputNumber == 5){
                    Console.Write("Record\n");
                }
            } while (inputNumber != 6);
            Console.Write("Good Bye\n");
    }
}