public abstract class Admin: Person
{

private List<string> _textList = new List<string>();
    
public void manageGrades() {
        Console.WriteLine("");
        string[] lines = System.IO.File.ReadAllLines("grades.txt");
        Console.WriteLine("");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
public abstract void DisplayOptions();
}