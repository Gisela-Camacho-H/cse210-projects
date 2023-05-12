public class RandomPrompt
{
    // Initialize our list
	// "Who was the most interesting person I interacted with today?",
    //"What was the best part of my day?",
    //"How did I see the hand of the Lord in my life today?",
    //"What was the strongest emotion I felt today?",
    //"if I had one thing I could do over today, what would it be?" });

    IDictionary<int, string> _prompts = new Dictionary<int, string>() {
	{0, "Who was the most interesting person I interacted with today?"},
	{1, "What was the best part of my day?"},
	{2, "How did I see the hand of the Lord in my life today?"}
};

public void Display()
    {
    Random randomGenerator = new Random();

    int number = randomGenerator.Next(0, 2);

        if(number == 0){  
            Console.WriteLine(_prompts[0]);
        }
        else if (number == 1)
        {
            Console.WriteLine(_prompts[1]);
        }
        else if (number == 2)
        {   
            Console.WriteLine(_prompts[2]);
        }	
}
}