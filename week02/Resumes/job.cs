using System;

public class Job
{
    public string _jobTitle;
    public string _Company;
    public int _StartYear;
    public int _EndYear;
    

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_Company}) {_StartYear} - {_EndYear}");
    }
}