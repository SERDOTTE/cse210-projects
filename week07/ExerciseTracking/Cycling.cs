using System;

public class Cycling : Activity
{
    private double _speed; // Speed in mph

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (GetSpeed() * GetMinutes()) / 60; // Distance in miles
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed(); // Pace in min per mile
    }
}