using System;

class Program
{
    static void Main(string[] args)
    {
        int inputNumber;
        Person myPerson = new Person();
        School mySchool = new School();
        Teacher myTeacher = new Teacher();
            do
            {
                mySchool.DisplayMenu();
                string userInput = Console.ReadLine();
                inputNumber = int.Parse(userInput);
                Console.WriteLine("");

                if (inputNumber == 1){
                    int parentNumber;
                    do
                    {
                        Parent myParent = new Parent();
                        myParent.DisplayOptions();
                        string parentInput = Console.ReadLine();
                        parentNumber = int.Parse(parentInput);
                        Console.Clear();
                        if (parentNumber == 1){
                        Console.WriteLine("Show Grades");
                        }

                    } while (parentNumber != 2);
                    Console.WriteLine("back to main menu");

                }
                else if (inputNumber == 2){
                    int studentNumber;
                    do
                    {
                        Student myStudent = new Student();
                        myStudent.DisplayOptions();

                    string studentInput = Console.ReadLine();
                    studentNumber = int.Parse(studentInput);
                    Console.Clear();
                        if (studentNumber == 1){
                        Console.WriteLine("Show Grades");
                        }

                    } while (studentNumber != 2);
                    Console.WriteLine("back to main menu");
                }
                else if (inputNumber == 3){
                    int secretaryNumber;
                    do
                    {
                        Secretary mySecretary = new Secretary();
                        mySecretary.DisplayOptions();

                    string secretaryInput = Console.ReadLine();
                    secretaryNumber = int.Parse(secretaryInput);
                    Console.Clear();
                        if (secretaryNumber == 1){
                        Console.WriteLine("Show Grades");
                        }

                    } while (secretaryNumber != 2);
                    Console.WriteLine("back to main menu");
                }
                else if (inputNumber == 4){
                    int teacherNumber;
                    string name;
                    int id;
                    string course;
                    string level;
                    double grade;
                    do
                    {
                        myTeacher.DisplayOptions();

                        string teacherInput = Console.ReadLine();
                        teacherNumber = int.Parse(teacherInput);
                        Console.Clear();
                        if (teacherNumber == 1){
                            Console.WriteLine("");
                            Console.Write("Student Name: \n");
                            name = Console.ReadLine();
                            Console.WriteLine("");
                            Console.Write("Id: \n");
                            string student_id = Console.ReadLine();
                            id = int.Parse(student_id);
                            Console.WriteLine("");
                            Console.Write("Course: \n");
                            course = Console.ReadLine();
                            Console.WriteLine("");
                            Console.Write("Level: \n");
                            level = Console.ReadLine();
                            Console.WriteLine("");
                            Console.Write("Grade: \n");
                            string student_grade = Console.ReadLine();
                            grade = double.Parse(student_grade);
                            Grade myGrade = new Grade();
                            myGrade._student_name = name;
                            myGrade._student_id = id;
                            myGrade._course = course;
                            myGrade._level = level;
                            myGrade._grade = grade;
                            myTeacher.Save(myGrade);
                        }
                        else if (teacherNumber == 2) {
                            myTeacher.Display();
                        }
                        else if(teacherNumber == 3) {
                            myTeacher.manageGrades();
                        }
                        else if (teacherNumber == 4) {
                            myTeacher.SaveFile();
                        }
                    } while (teacherNumber != 5);
                    Console.WriteLine("back to main menu"); 
                }
                else if (inputNumber == 5){
                    int principalNumber;
                    do
                    {
                        Principal myPrincipal = new Principal();
                        myPrincipal.DisplayOptions();

                    string principalInput = Console.ReadLine();
                    principalNumber = int.Parse(principalInput);
                    Console.Clear();
                        if (principalNumber == 1){
                        Console.WriteLine("Show Grades");
                        }

                    } while (principalNumber != 2);
                    Console.WriteLine("back to main menu");
                }
            } while (inputNumber != 6);
            Console.Write("Good Bye\n");
    }
}