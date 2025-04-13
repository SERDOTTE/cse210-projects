public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _currentCount++;
            Console.WriteLine($"Goal '{Name}' recorded! You earned {Points} points.");
            if (IsComplete())
            {
                Console.WriteLine($"Congratulations! You completed the goal '{Name}' and earned a bonus of {_bonusPoints} points!");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already completed.");
        }
    }

    public override string GetStatus()
    {
        return IsComplete() ? $"[X] Completed {_currentCount}/{_targetCount} times" : $"[ ] Completed {_currentCount}/{_targetCount} times";
    }

    public int TargetCount => _targetCount;
    public int CurrentCount => _currentCount;
    public int BonusPoints => _bonusPoints;

    public void SetCurrentCount(int currentCount)
    {
        _currentCount = currentCount;
    }
}