public class Grade
{
    public string _student_name;
    public int _student_id;
    public string _course;
    public string _level;
    public double _grade;

    public void DisplayGrade()
    {
        Console.WriteLine("");
        Console.WriteLine($"Student Name : {_student_name} - Id: {_student_id}, Course: {_course} - Level: {_level}: Grade: {_grade}");
    }
}