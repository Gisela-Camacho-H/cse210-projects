using System;

class Program
{
    static void Main(string[] args)
    {
        int inputNumber;
        int inputNumberTime;
            do
            {
                Console.WriteLine("");
                Console.Write("Menu Option:\n");
                Console.WriteLine("");
                Console.Write("1. Start breathing activity\n");
                Console.Write("2. Start reflection activity\n");
                Console.Write("3. Start listing activity\n");
                Console.Write("4. Start Reading Quotes activity\n");
                Console.Write("5. Quit\n");
                Console.WriteLine("");
                Console.Write("Select a choice from the menu: ");
                string userInput = Console.ReadLine();
                inputNumber = int.Parse(userInput);
                Console.WriteLine("");

                Activity myActivity = new Activity();
                Console.Clear();
                if (inputNumber < 4 || inputNumber > 1)
                {
                myActivity.DisplayStartMessage(inputNumber);
                }
                if (inputNumber == 1 || inputNumber == 2 || inputNumber == 3 || inputNumber == 4)
                {
                    Console.WriteLine("");
                    Console.Write("How long, in seconds, would you like for your session? ");
                    string userInputTime = Console.ReadLine();
                    inputNumberTime = int.Parse(userInputTime);
                    Console.WriteLine("");
                    Console.Clear();
                    Console.WriteLine("Get ready...");
                    myActivity.Animation();
                    Console.Clear();
                    Thread.Sleep(1000);
                    if (inputNumber == 1){
                        Breathing myBreathing = new Breathing();
                        myBreathing.DisplayMessageBreathe(inputNumberTime);
                    }
                    else if (inputNumber == 2){
                    DateTime currentTime;
                    Console.WriteLine("Consider the following prompt:");
                    Reflection myReflection =  new Reflection();
                    DateTime futureTime = myReflection.GiveFutureTime(inputNumberTime);
                    Console.WriteLine("");
                    myReflection.DisplayPrompts();
                    myReflection.DisplayMiddleMessage();
                    myReflection.CountDown(3);
                    Console.WriteLine("");
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("");
                        myReflection.DisplayQuestions();
                        Console.Write("  ");
                        myReflection.Animation();
                        myReflection.Animation();
                        Console.WriteLine("");
                        currentTime = DateTime.Now;
                    } while (currentTime < futureTime);
                }
                else if (inputNumber == 3){
                    Console.WriteLine("List as many responses you can to the following prompt: ");
                    Console.WriteLine("");
                    Listing myListing = new Listing();
                    myListing.DisplayPrompt();
                    Console.WriteLine("");
                    Console.Write("You may begin in:  ");
                    myListing.CountDown(5);
                    DateTime currentTime;
                    Console.WriteLine(" ");
                    DateTime startTime = DateTime.Now;
                    DateTime futureTime = startTime.AddSeconds(inputNumberTime);
                    int count = 0;
                    do
                    {
                        Console.Write("< ");
                        Console.ReadLine();
                        count += 1;
                        currentTime = DateTime.Now;
                    } while (currentTime < futureTime);
                    Console.WriteLine("");
                    Console.WriteLine($"You Listed {count} items!");
                    Thread.Sleep(3000);
                }
                else if (inputNumber == 4){
                    Console.WriteLine("Read and ponder of the quotes that will be displayed ");
                    Console.WriteLine("");
                    Reading myReading = new Reading();
                    DateTime currentTime;
                    DateTime startTime = DateTime.Now;
                    DateTime futureTime = startTime.AddSeconds(inputNumberTime);
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("");
                        myReading.DisplayQuotes();
                        Console.Write("  ");
                        myReading.Animation();
                        myReading.Animation();
                        Console.WriteLine("");
                        currentTime = DateTime.Now;
                    } while (currentTime < futureTime);
                    
                }
                Console.WriteLine("");
                Console.WriteLine("Well done!!");
                string activityName = "";
                if (inputNumber == 1){ activityName = "Breathing"; }
                else if (inputNumber == 2){ activityName = "Reflecting"; }
                else if (inputNumber == 3){ activityName = "Listing"; }
                else if (inputNumber == 4){ activityName = "Reading"; }
                myActivity.DisplayEndMessage(activityName, inputNumberTime);
                myActivity.Animation();
                Console.Clear();
                }
            } while (inputNumber != 5);
            Console.Write("Good Bye\n");
    }

    private static string stirng(int inputNumber)
    {
        throw new NotImplementedException();
    }
}