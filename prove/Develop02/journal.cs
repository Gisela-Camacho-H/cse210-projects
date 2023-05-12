public class Journal
{
    public string _name;
    public List<Entry> _entry = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entry)
        {
            entry.Display();
        }
    }
        public void Save(Entry entry)
    {
            _entry.Add(entry);
    }
}