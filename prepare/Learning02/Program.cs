using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1  = new Job();
        job1._company = "Madata";
        job1._jobTitle = "Service Desk Agent";
        job1._startYear = 2019;
        job1._endYear = 2020;
        
        Job job2  = new Job();
        job2._company = "Robert Bosch";
        job2._jobTitle = "SAP SD";
        job2._startYear = 2020;
        job2._endYear = 2022;


        Resume myResume  = new Resume();
        myResume._name= "Remi Barron";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobDetails();
    }
}