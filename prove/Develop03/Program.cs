using System;

class Program
{
    static void Main(string[] args)
    {
        string inputText;
        Reference myReference = new Reference("Proverbs", "3", "5", "6");
        Scripture myScripture = new Scripture();
        Word myWord = new Word();

        List<string> scriptureText = myScripture.ConvertToList("I will go and do");
        string displayReference = myReference.GetReferenceMoreVerse();
        List<string> ConvertList = myScripture.ConvertToList("I will go and do");
        string displayScriptureText = string.Join(" ", ConvertList);
        Console.WriteLine(displayReference + " " + displayScriptureText);
            do
            {
                inputText = Console.ReadLine();
                List<int> index = new List<int>();
                for(int i = 0; i <= 2; i++){
                    int i1 = myScripture.RandomWord(ConvertList);
                    index.Add(i1);
                } 
                string underscoredword1 = myScripture.ConvertToUnderscores(ConvertList[index[0]]);
                Console.WriteLine(ConvertList[index[0]]);
                Console.WriteLine(underscoredword1);
                string underscoredword2 = myScripture.ConvertToUnderscores(ConvertList[index[1]]);
                Console.WriteLine(ConvertList[index[1]]);
                Console.WriteLine(underscoredword2);
                string underscoredword3 = myScripture.ConvertToUnderscores(ConvertList[index[2]]);
                Console.WriteLine(ConvertList[index[2]]);
                Console.WriteLine(underscoredword3);

                
            } while (inputText != "quit");
            Console.Write("Good Bye\n");
    }
}