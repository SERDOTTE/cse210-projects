using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            _totalPoints += goal.GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. { _goals[i].GetStatus()} { _goals[i].Name} - { _goals[i].Description}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Points: {_totalPoints}");
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    // Method to save goals to a file
    public void SaveGoals(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_totalPoints); // Save total points
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetType().Name); // Save goal type
                    writer.WriteLine(goal.Name);
                    writer.WriteLine(goal.Description);
                    writer.WriteLine(goal.Points);

                    if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine(checklistGoal.TargetCount);
                        writer.WriteLine(checklistGoal.CurrentCount);
                        writer.WriteLine(checklistGoal.BonusPoints);
                    }
                    else if (goal is EternalGoal eternalGoal)
                    {
                        writer.WriteLine(eternalGoal.TimesCompleted);
                    }
                    else if (goal is SimpleGoal simpleGoal)
                    {
                        writer.WriteLine(simpleGoal.IsComplete());
                    }
                }
            }
            Console.WriteLine($"Goals successfully saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving goals: {ex.Message}");
        }
    }

    // Method to load goals from a file
    public void LoadGoals(string filename)
    {
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            _totalPoints = int.Parse(reader.ReadLine()); // Load total points
            while (!reader.EndOfStream)
            {
                string goalType = reader.ReadLine();
                string name = reader.ReadLine();
                string description = reader.ReadLine();
                int points = int.Parse(reader.ReadLine());

                if (goalType == nameof(SimpleGoal))
                {
                    bool isComplete = bool.Parse(reader.ReadLine());
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    if (isComplete)
                    {
                        simpleGoal.MarkComplete();
                    }
                    _goals.Add(simpleGoal);
                }
                else if (goalType == nameof(EternalGoal))
                {
                    int timesCompleted = int.Parse(reader.ReadLine());
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    eternalGoal.SetTimesCompleted(timesCompleted);
                    _goals.Add(eternalGoal);
                }
                else if (goalType == nameof(ChecklistGoal))
                {
                    int targetCount = int.Parse(reader.ReadLine());
                    int currentCount = int.Parse(reader.ReadLine());
                    int bonusPoints = int.Parse(reader.ReadLine());
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                    checklistGoal.SetCurrentCount(currentCount);
                    _goals.Add(checklistGoal);
                }
            }
        }
    }
}