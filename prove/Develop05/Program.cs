using System;

class Program
{
    static void Main(string[] args)
    {
        int inputNumber;
        int goalNumber;
        Goals myGoal = new Goals();
        myGoal._listing_goals = new List<string>();
        myGoal._saving_goals = new List<string>();
        myGoal._show_goals = new List<string>();
            do
            {
                Console.WriteLine("");
                myGoal.getPoints();
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
                do
                {
                Console.WriteLine("");
                Console.Write("The types of Goals are:\n");
                Console.WriteLine("");
                Console.Write("1. Simple Goal\n");
                Console.Write("2. Eternal Goal\n");
                Console.Write("3. Checklist Goal\n");
                Console.Write("4. Physical Goal\n");
                Console.WriteLine("");
                Console.Write("Which type of goal would you like to create? ");
                string userEntry = Console.ReadLine();
                myGoal._goal_type = int.Parse(userEntry);
                Console.WriteLine("");
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                string userPoints = Console.ReadLine();
                int points = int.Parse(userPoints);
                Console.Clear();
                if (myGoal._goal_type == 1){
                    Simple mySimple =  new Simple();
                    mySimple._name = name;
                    mySimple._description = description;
                    mySimple._points = points;
                    String goalData = $"{mySimple._name} ({mySimple._description})";
                    if (myGoal._is_completed) {
                        String goal = "[x] " + goalData;
                        myGoal._listing_goals.Add(goal);  
                    } else {
                      String goal = "[ ] " + goalData;
                        myGoal._listing_goals.Add(goal); 
                    }
                    String saveData = $"SimpleGoal: {mySimple._name} , {mySimple._description} , {mySimple._points} , {mySimple._ready}";
                    myGoal._saving_goals.Add(saveData); 
                    myGoal._show_goals.Add(mySimple._name); 
                }
                else if (myGoal._goal_type == 2){
                    Eternal myEternal =  new Eternal();
                    myEternal._name = name;
                    myEternal._description = description;
                    myEternal._points = points;
                    String goalData = $"{myEternal._name} ({myEternal._description})";
                    if (myGoal._is_completed) {
                        String goal = "[x] " + goalData;
                        myGoal._listing_goals.Add(goal);  
                    } else {
                      String goal = "[ ] " + goalData;
                        myGoal._listing_goals.Add(goal); 
                    }
                    String saveData = $"EternalGoal: {myEternal._name} , {myEternal._description} , {myEternal._points}";
                    myGoal._saving_goals.Add(saveData); 
                    myGoal._show_goals.Add(myEternal._name); 
                }
                else if (myGoal._goal_type == 3){    
                    Checklist myChecklist =  new Checklist();
                    myChecklist._name = name;
                    myChecklist._description = description;
                    myChecklist._points = points;
                    myChecklist._attempt = 0;
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string userTimes = Console.ReadLine();
                    myChecklist._limit = int.Parse(userTimes);
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string userbonus = Console.ReadLine();
                    myChecklist._bonus = int.Parse(userbonus);
                    String goalData = $"{myChecklist._name} ({myChecklist._description}) -- Currently completed: {myChecklist._attempt}/{myChecklist._limit}";
                    if (myGoal._is_completed) {
                        String goal = "[x] " + goalData;
                        myGoal._listing_goals.Add(goal);  
                    } else {
                      String goal = "[ ] " + goalData;
                        myGoal._listing_goals.Add(goal); 
                    }
                    String saveData = $"ChecklistGoal: {myChecklist._name} , {myChecklist._description} , {myChecklist._points} , {myChecklist._bonus} , {myChecklist._limit} , {myChecklist._attempt}";
                    myGoal._saving_goals.Add(saveData); 
                    myGoal._show_goals.Add(myChecklist._name); 
                }
                else if (myGoal._goal_type == 4){    
                    Physical myPhysical =  new Physical();
                    myPhysical._name = name;
                    myPhysical._description = description;
                    myPhysical._points = points;
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string userTimes = Console.ReadLine();
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string userbonus = Console.ReadLine();
                    String goalData = $"{myPhysical._name} ({myPhysical._description})";
                    if (myGoal._is_completed) {
                        String goal = "[x] " + goalData;
                        myGoal._listing_goals.Add(goal);  
                    } else {
                      String goal = "[ ] " + goalData;
                        myGoal._listing_goals.Add(goal); 
                    }
                    String saveData = $"ChecklistGoal: {myPhysical._name} , {myPhysical._description} , {myPhysical._points}";
                    myGoal._saving_goals.Add(saveData); 
                }
                else {
                    Console.WriteLine("Choose a right number of goal");
                }
            } while (myGoal._goal_type > 4 && myGoal._goal_type < 1);

                }
                else if (inputNumber == 2){
                    if (myGoal._listing_goals.Count == 0){
                        Console.WriteLine("You don't have register goals yet");
                    } else {
                    for(int i=0;i<myGoal._listing_goals.Count;i++)
                        {
                        Console.WriteLine($"{i+1}. " + myGoal._listing_goals[i]);
                        }
                    }
                }
                else if (inputNumber == 3){    
                    Console.WriteLine("");
                    Console.Write("What is the filename?\n");
                    string filename = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    foreach (String goal in myGoal._saving_goals)
                    {
                        outputFile.WriteLine(goal);
                    }   
                }
                else if (inputNumber == 4){
                    Console.WriteLine("");
                    Console.Write("What is the filename?\n");
                    string filename = Console.ReadLine();

                    string[] lines = System.IO.File.ReadAllLines(filename);
                    Console.WriteLine("");
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else if (inputNumber == 5){
                    if (myGoal._show_goals.Count == 0){
                        Console.WriteLine("You don't have register goals yet");
                    } else {
                    Console.WriteLine("The goals are: ");
                    for(int i=0;i<myGoal._show_goals.Count;i++)
                        {
                        Console.WriteLine($"{i+1}. " + myGoal._show_goals[i]);
                        }
                    }
                    Console.Write("Select a choice from the menu: ");
                    string number = Console.ReadLine();
                    goalNumber = int.Parse(number);
                    Console.WriteLine($"Congratulation! You have earned {myGoal._listing_goals[goalNumber - 1]} ");

                }
            } while (inputNumber != 6);
            Console.Write("Good Bye\n");
    }
}