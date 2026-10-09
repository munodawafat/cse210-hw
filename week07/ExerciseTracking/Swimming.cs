using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 0.05; // Distance in miles (assuming each lap is 50 meters)
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60; // Speed in miles per hour
    }

    public override double GetPace()
    {
        return (double)_length / GetDistance(); // Pace in minutes per mile
    }
}