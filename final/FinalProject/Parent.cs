public class Parent: User
{
    
    public override void showGrades() {
       Console.WriteLine("");
    }

    public override void DisplayOptions()
    {
        Console.WriteLine("");
        Console.Write("Menu Option:\n");
        Console.WriteLine("");
        Console.Write("1. Show grades\n");
        Console.Write("2. Quit\n");
        Console.WriteLine("");
        Console.Write("Select the option: ");
    }

    public void printParentGrade(int id) {
    string student_id = $"{id}";

    string[] lines = System.IO.File.ReadAllLines("grades.txt");
    Console.WriteLine("");
    foreach (string line in lines)
        {
             if (line.Contains(student_id)){
                Console.WriteLine(line);
             }
        }
    }
}