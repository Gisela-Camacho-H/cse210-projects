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
}