public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _timesCompleted = 0;
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
        Console.WriteLine($"Goal '{Name}' recorded! You earned {Points} points.");
    }

    public override string GetStatus()
    {
        return $"[ ] Completed {_timesCompleted} times";
    }

    public int TimesCompleted => _timesCompleted;

    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }
}