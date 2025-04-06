using System;
using System.Threading;

public class BreathingActivity : Activity
{
    private static int _timesCompleted = 0; // Static counter for this activity

    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Now breathe out...");
            ShowCountdown(6);
            Console.WriteLine();
            elapsed += 10; // Each cycle takes 10 seconds
        }
    }

    protected override void IncrementTimesCompleted()
    {
        _timesCompleted++;
    }

    // Method to get the number of times this activity was completed
    public static int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}