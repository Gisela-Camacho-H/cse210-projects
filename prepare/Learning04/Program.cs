using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment();
        myAssignment.SetTopic("Multiplication");
        myAssignment.SetStudentName("Samuel Bennett");
        
        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine("");

        MathAssignment myMathAssingment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 9 - 19");
        Console.WriteLine(myMathAssingment.GetSummary());
        Console.WriteLine(myMathAssingment.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment myWritingAssingment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(myWritingAssingment.GetSummary());
        Console.WriteLine(myWritingAssingment.GetWritingInformation());
    }
}