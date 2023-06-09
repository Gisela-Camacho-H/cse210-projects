public class Activity
{
    protected int _time;

    public int GetTime()
    {
        return _time;
    }

    public void SetTime(int time)
    {
        _time = time;
    }
    public void DisplayStartMessage(int activityNumber)
    {
        if (activityNumber == 1)
        {
            Console.WriteLine("Welcome to the Breathing Activity");
            Console.WriteLine("");
            Console.WriteLine("This Activity will help you relax by walking your breathing in an out slowly.");
            Console.WriteLine("Clear your mind and focus on your breathing.");
        }
        else if (activityNumber == 2)
        {
            Console.WriteLine("Welcome to the Reflection Activity"); 
            Console.WriteLine("");
            Console.WriteLine("This Activity will help you reflect on the good things in your life by having you list as many things");
            Console.WriteLine("as you can in certain area.");
        }
        else if (activityNumber == 3)
        {
            Console.WriteLine("Welcome to the Listing Activity"); 
            Console.WriteLine("");
            Console.WriteLine("This Activity will help you relax by walking your breathing in an out slowly.");
            Console.WriteLine("Clear your mind and focus on your breathing.");
        } 
        else if (activityNumber == 4)
        {
            Console.WriteLine("Welcome to the Reading Activity"); 
            Console.WriteLine("");
            Console.WriteLine("This Activity will help you Read awesome quotes and ponder about them");
        } 
    }

    public void DisplayEndMessage(string activityName, int time)
    {
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {time} seconds of the {activityName} Activity.");
    }

    public void CountDown(int number)
    {
        do
        {
            Console.Write("\b \b");
            Console.Write(number); 
            number -= 1;
            Thread.Sleep(1000);
        } while (number != 0);
        Console.Write("\b \b");
    }

    public int RandomNumber()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(3, 6);
        return number;
    }

    public DateTime GiveFutureTime(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        return futureTime;
    }

    public void Animation()
    {
        int count= 0;
        do
        {
            Console.Write("\b \b");
            Console.Write("/"); 
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("-"); 
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("-"); 
            count += 1;
    } while (count != 6);
    }
}