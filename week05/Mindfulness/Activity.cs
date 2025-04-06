using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // Constructor to initialize the activity
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Method to start the activity
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        Console.WriteLine();
        ShowSpinner(3); // Pause for 3 seconds with a spinner
        PerformActivity();
        IncrementTimesCompleted(); // Increment the counter
        End();
    }

    // Abstract method to be implemented by derived classes
    protected abstract void PerformActivity();

    // Virtual method to increment times completed, to be overridden in derived classes
    protected virtual void IncrementTimesCompleted()
    {
        // This will be overridden in derived classes
    }

    // Method to end the activity
    private void End()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(6); // Pause for 3 seconds with a spinner
    }

    // Method to show a spinner animation
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    // Method to get the duration of the activity
    protected int GetDuration()
    {
        return _duration;
    }
}