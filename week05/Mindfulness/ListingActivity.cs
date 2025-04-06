using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static int _timesCompleted = 0;

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are people you have helped this week?",
        "When have you felt the Holy Spirit this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _usedPrompts = new List<string>(); // Tracks used prompts in the session

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = GetNextPrompt(random);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        ShowSpinner(5); // Pause for 5 seconds

        Console.WriteLine("You may begin now:");
        int duration = GetDuration();
        int elapsed = 0;
        int count = 0;
        DateTime startTime = DateTime.Now;

        while (elapsed < duration)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
            elapsed = (int)(DateTime.Now - startTime).TotalSeconds;
        }

        Console.WriteLine($"You listed {count} items!");
    }

    private string GetNextPrompt(Random random)
    {
        // If all prompts have been used, reset the list
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        // Select a prompt that hasn't been used yet
        string prompt;
        do
        {
            prompt = _prompts[random.Next(_prompts.Count)];
        } while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt); // Mark the prompt as used
        return prompt;
    }

    protected override void IncrementTimesCompleted()
    {
        _timesCompleted++;
    }

    public static int GetTimesCompleted()
    {
        return _timesCompleted;
    }
}