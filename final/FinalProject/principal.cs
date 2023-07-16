public class Principal: Admin
{
    public override void DisplayOptions()
    {
        Console.WriteLine("");
        Console.Write("Menu Option:\n");
        Console.WriteLine("");
        Console.Write("1. Show all students grades\n");
        Console.Write("2. Print teachers information\n");
        Console.Write("3. Quit\n");
        Console.WriteLine("");
        Console.Write("Select the option: ");
    }

    public void showTeachers() {
        Console.WriteLine("");
        string[] lines = System.IO.File.ReadAllLines("teachers.txt");
        Console.WriteLine("");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}