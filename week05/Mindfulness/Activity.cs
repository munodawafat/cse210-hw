using System;

public class Activity
{
    private string _Name;
    private string _Description;
    private int _Duration;

    public Activity(string name, string description)
    {
        _Name = name;
        _Description = description;
        _Duration = 0;
    }
    public void SetDuration(int duration)
    {
        _Duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_Name} Activity");
        Console.WriteLine(_Description);
        Console.WriteLine($"Duration: {_Duration} seconds");
        Console.WriteLine("Press any key to begin...");
        Console.ReadKey();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_Name} Activity");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    public void ShowSpinner()
    {
        // Implementation for spinner animation
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
        }
    }
    public void ShowCountDown()
    {
        for (int i = _Duration; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }   
    }
}