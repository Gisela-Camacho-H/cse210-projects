public class Principal: Admin
{
    public void offer_scholarship() { }
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