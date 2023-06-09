public class Reflection: Activity
{
    private IDictionary<int, string> _prompt = new Dictionary<int, string>() {
	{0, "---- Think of a time when you stood up for someone else. ---- "},
	{1, "---- Think of a time when you did something really difficult. ---- "},
	{2, "---- Think of a time when you helped someone in need. ---- "},
    {3, "---- Think of a time when you did something truly selfless. ---- "}
};

    private IDictionary<int, string> _question = new Dictionary<int, string>() {
	{0, "---- Why was this experience meaningful to you? ---- "},
	{1, "---- Have you ever done anything like this before? ---- "},
	{2, "---- How did you get started? ---- "},
    {3, "---- How did you feel when it was complete? ---- "},
	{4, "---- What made this time different than other times when you were not as successful? ---- "},
    {5, "---- What is your favorite thing about this experience? ---- "},
    {6, "---- What could you learn from this experience that applies to other situations? ---- "},
    {7, "---- What did you learn about yourself through this experience? ---- "},
    {8, "---- How can you keep this experience in mind in the future? ---- "}
};

    public void DisplayPrompts()
    {
        Random randomGenerator = new Random();

        int number = randomGenerator.Next(0, 4);

        string prompt =  _prompt[number];
        Console.WriteLine(prompt);
    }

    public void DisplayMiddleMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:  ");
    }
    public void DisplayQuestions()
    {
        Random randomGenerator = new Random();

        int number = randomGenerator.Next(0, 9);

        string question =  _question[number];
        Console.Write(question);
    }
}