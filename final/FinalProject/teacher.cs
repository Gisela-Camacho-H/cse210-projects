public class Teacher: Admin
{
    public List<Grade> _grade = new List<Grade>();

    public void Display()
    {
        foreach (Grade grade in _grade)
        {
            grade.DisplayGrade();
        }
    }
    
    public void Save(Grade grade)
    {
            _grade.Add(grade);
    }
    
    public void SaveFile()
    { 
        Console.WriteLine("");
        Console.Write("What is the filename?\n");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        foreach (Grade grade in _grade)
        {
            outputFile.WriteLine($"Student Name : {grade._student_name} - Id: {grade._student_id}, Course: {grade._course} - Level: {grade._level}: Grade: {grade._grade}");
        }
    }

    public override void DisplayOptions(){
        Console.WriteLine("");
        Console.Write("Grades Options\n");
        Console.WriteLine("");
        Console.Write("1. Write\n");
        Console.Write("2. Display\n");
        Console.Write("3. Load\n");
        Console.Write("4. Save\n");
        Console.Write("5. Quit\n");
        Console.WriteLine("");
        Console.Write("What would you like to do? ");
    }
}