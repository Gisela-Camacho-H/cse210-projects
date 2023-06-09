public class Listing : Activity
{

    private IDictionary<int, string> _listing_prompt = new Dictionary<int, string>() {
	{0, "---- Who are people that you appreciate? ---- "},
	{1, "---- What are personal strengths of yours? ---- "},
	{2, "---- Who are people that you have helped this week? ---- "},
    {3, "---- When have you felt the Holy Ghost this month? ---- "},
	{4, "---- Who are some of your personal heroes? ---- "}
};
    public void DisplayPrompt()
    {
        Random randomGenerator = new Random();

        int number = randomGenerator.Next(0, 5);

        string prompt =  _listing_prompt[number];
        Console.WriteLine(prompt);
    }
}