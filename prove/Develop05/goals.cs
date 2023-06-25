public class Goals
{
    public int _total_points;
    public string _name;
    public int _goal_type;
    public string _description;
    public int _points;
    public List<string> _listing_goals = new List<string>();
    public List<string> _saving_goals = new List<string>();
    public List<string> _show_goals = new List<string>();
    protected string _goal;
    public bool _is_completed = false;

    public int GetTime()
    {
        return _total_points;
    }

    public void SetTime(int total_points)
    {
        _total_points= total_points;
    }
    public void GoalCompleted()
    {
    }

    public void getPoints(){
        _total_points = 0;
        Console.WriteLine($"You have {_total_points} points");
    }
}