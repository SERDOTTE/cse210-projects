using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance(); // Distance in miles or kilometers
    public abstract double GetSpeed();    // Speed in mph or kph
    public abstract double GetPace();     // Pace in min per mile or min per km

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} ({_minutes} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile";
    }
}