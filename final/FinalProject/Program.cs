using System;

class Program
{
    static void Main(string[] args)
    {
        int inputNumber;
        Person myPerson = new Person();
        School mySchool = new School();
        Teacher myTeacher = new Teacher();
        Secretary mySecretary =  new Secretary();
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
                    string student_name;
                    int student_id;
                    string student_course;
                    string teacher_name;
                    int teacher_id;
                    string teacher_course;
                    do
                    {
                        mySecretary.DisplayOptions();

                    string secretaryInput = Console.ReadLine();
                    secretaryNumber = int.Parse(secretaryInput);
                    Console.Clear();
                        if (secretaryNumber == 1){
                            mySecretary.manageGrades();
                        }
                        else if (secretaryNumber == 2){
                            mySecretary._students.Clear();
                            Console.Write("Search by student name, id, course, level or grade: ");
                            string searchInput = Console.ReadLine();
                            mySecretary.printByStudent(searchInput);
                        }
                        else if (secretaryNumber == 3){
                            Console.WriteLine("");
                            Console.Write("Student Name: \n");
                            student_name = Console.ReadLine();
                            Console.WriteLine("");
                            Console.Write("Id: \n");
                            string student_int_id = Console.ReadLine();
                            student_id = int.Parse(student_int_id);
                            Console.WriteLine("");
                            Console.Write("Course: \n");
                            student_course = Console.ReadLine();
                            Console.WriteLine("");
                            Student myStudent = new Student();
                            myStudent._name = student_name;
                            myStudent._id = student_id;
                            myStudent._course = student_course;
                            mySecretary.SaveStudent(myStudent);
                            mySecretary.SaveFileStudent();
                        }
                        else if (secretaryNumber == 4){
                            Console.WriteLine("");
                            Console.Write("Teacher Name: \n");
                            teacher_name = Console.ReadLine();
                            Console.WriteLine("");
                            Console.Write("Id: \n");
                            string teacher_int_id = Console.ReadLine();
                            teacher_id = int.Parse(teacher_int_id);
                            Console.WriteLine("");
                            Teacher registerTeacher = new Teacher();
                            registerTeacher._name = teacher_name;
                            registerTeacher._id = teacher_id;
                            mySecretary.SaveTeacher(registerTeacher);
                            mySecretary.SaveFileTeacher();
                        }

                    } while (secretaryNumber != 5);
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