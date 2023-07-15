public abstract class Admin: Person
{

private List<string> _textList = new List<string>();
    
public void manageGrades() {
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
public abstract void DisplayOptions();
}