public class Entry
{
    public string _date;
    public string _entry;

    public void Display()
    {
        Console.WriteLine($"{_date} {_entry}");
    }
        public void Modify()
    {
        Console.WriteLine($"{_date} ({_entry}");
    }
}