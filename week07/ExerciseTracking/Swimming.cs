using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62; // Distance in miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60; // Speed in mph
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance(); // Pace in min per mile
    }
}