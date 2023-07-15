public class Student: User
{
    
    private string _course;

    public List<Grade> _entry = new List<Grade>();

    public void choose_language()
    { }
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