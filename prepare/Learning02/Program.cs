using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Science Teaher";
        job1._company = "InterCanadiense";
        job1._startYear = 2015;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "iOS DEveloper";
        job2._company = "Globant";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Gisela Camacho";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}