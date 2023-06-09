public class Breathing: Activity
{
    public void DisplayMessageBreathe(int inputTime)
    {
        do
        {
            Console.WriteLine("");
            Console.Write("Breathe in....");
            int number = RandomNumber();
            CountDown(number);
            inputTime -= number;
            int number2 = RandomNumber();
            Console.WriteLine("");
            Console.Write("Breathe out....");
            CountDown(number2);
            Console.WriteLine("");
            inputTime -= number2;
        } while (inputTime >= 5);
    }

    internal void DisplayMessageBreathe()
    {
        throw new NotImplementedException();
    }
}