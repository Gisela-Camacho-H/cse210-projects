using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        int inputNumber;
        string entry;
        string dateText;
        List<Entry> _entryList = new List<Entry>();
        Journal myJournal = new Journal();
        RandomPrompt random =  new RandomPrompt();
        
            do
            {
                Console.Write("Welcome to the Journal Program!\n");
                Console.Write("1. Write\n");
                Console.Write("2. Display\n");
                Console.Write("3. Load\n");
                Console.Write("4. Save\n");
                Console.Write("5. Quit\n");
                Console.Write("What would you like to do? ");
                string userInput = Console.ReadLine();
                inputNumber = int.Parse(userInput);
                string prompt = "Who was the most interesting person I interacted with today?\n";

                if (inputNumber == 1)
                {
                    random.Display();
                    entry = Console.ReadLine();
                    DateTime theCurrentTime = DateTime.Now;
                    dateText = theCurrentTime.ToShortDateString();
                    Entry myEntry = new Entry();
                    myEntry._date = dateText;
                    myEntry._entry = entry;
                    myJournal.Save(myEntry);
                }
                else if (inputNumber == 2)
                {
                    myJournal.Display();
                }
                else if (inputNumber == 3)
                {
                    string filename = "myFile.txt";
                    string[] lines = System.IO.File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(",");

                        string firstName = parts[0];
                        string lastName = parts[1];
                    }
                } 
                else if (inputNumber == 4)
                {
                    string fileName = "myFile.txt";
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {  
                    //outputFile.WriteLine($" {entry}");
                    }
                }
 
            } while (inputNumber != 5);
            Console.Write("Good Bye");
    }
}