public class School
{
    public string _school_name;
    public string _school_id;

    public void DisplayMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to Language School");
        Console.WriteLine("");
        Console.Write("Menu Option:\n");
        Console.WriteLine("");
        Console.Write("1. Parent\n");
        Console.Write("2. Student\n");
        Console.Write("3. Secretary\n");
        Console.Write("4. Teacher\n");
        Console.Write("5. Principal\n");
        Console.Write("6. Quit\n");
        Console.WriteLine("");
        Console.Write("Select your Rol in the school: ");
    }
}