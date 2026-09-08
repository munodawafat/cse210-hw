using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Transmission Technician";
        job1._Company = "Telone";
        job1._StartYear = 2010;
        job1._EndYear = 2012;

        Job job2 = new Job();
        job2._jobTitle = "Telecom Technician";
        job2._Company = "Econet";
        job2._StartYear = 2014;
        job2._EndYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Tapiwa Phineas Munodawafa";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}