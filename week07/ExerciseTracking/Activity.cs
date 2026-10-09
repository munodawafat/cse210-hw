using System;

public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public void DisplaySummary()
    {
        Console.WriteLine($"Name: {this.GetType().Name}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Length: {_length} minutes");
        Console.WriteLine($"Distance: {GetDistance()} miles");
        Console.WriteLine($"Speed: {GetSpeed()} mph");
        Console.WriteLine($"Pace: {GetPace()} min/mile");
    }
}