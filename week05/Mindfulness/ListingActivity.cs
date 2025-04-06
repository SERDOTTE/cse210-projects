using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are people you have helped this week?",
        "When have you felt the Holy Spirit this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");
        ShowSpinner(5); // Pause for 5 seconds

        Console.WriteLine("You may begin now:");
        int duration = GetDuration(); // Get the duration specified by the user
        int elapsed = 0;
        int count = 0;
        DateTime startTime = DateTime.Now;

        while (elapsed < duration)
        {
            Console.Write("> ");
            Console.ReadLine(); // Read user input
            count++;
            elapsed = (int)(DateTime.Now - startTime).TotalSeconds; // Update elapsed time
        }

        Console.WriteLine($"You listed {count} items!");
    }
}