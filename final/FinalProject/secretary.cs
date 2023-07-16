using System;
using System.Linq;
using System.Collections.Generic;
public class Secretary: Admin
{
    public List<String> _grades = new List<String>();
    public List<String> _students = new List<String>();

    public List<Student> _students_register = new List<Student>();

    public List<Teacher> _teachers_register = new List<Teacher>();
    public override void DisplayOptions()
    {
        Console.WriteLine("");
        Console.Write("Menu Option:\n");
        Console.WriteLine("");
        Console.Write("1. Show all Students\n");
        Console.Write("2. Search\n");
        Console.Write("3. Register Students\n");
        Console.Write("4. Register Teachers\n");
        Console.Write("5. Quit\n");
        Console.WriteLine("");
        Console.Write("Select the option: ");
    }

    private void saveAllRegisters() {
        Console.WriteLine("");
        Console.Write("What is the filename?\n");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        Console.WriteLine("");
        foreach (string line in lines)
        {
            _grades.Add(line);
        }
    }

    public void printByStudent(string id) {

        saveAllRegisters();
        foreach (string grade in _grades)
        {
            if (grade.Contains(id)){
                _students.Add(grade);
                foreach (string student in _students){
                    Console.WriteLine(student);
                }
                _students.Clear();
            }
        }
    }

    public void SaveTeacher(Teacher teacher)
    {
            _teachers_register.Add(teacher);
    }
    public void SaveFileTeacher()
    { 
        Console.WriteLine("");
        Console.Write("What is the filename?\n");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        foreach (Teacher teacher in _teachers_register)
        {
            outputFile.WriteLine($"Teacher Name : {teacher._name} - Id: {teacher._id}");
        }
    }

    public void SaveStudent(Student student)
    {
            _students_register.Add(student);
    }
    public void SaveFileStudent()
    { 
        Console.WriteLine("");
        Console.Write("What is the filename?\n");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        foreach (Student student in _students_register)
        {
            outputFile.WriteLine($"Student Name : {student._name} - Id: {student._id} - Course {student._course}");
        }
    }

    internal void printByStudent()
    {
        throw new NotImplementedException();
    }
}