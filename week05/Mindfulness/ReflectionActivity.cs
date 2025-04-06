using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private static int _timesCompleted = 0;

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you accomplished something difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "> Why was this experience meaningful to you?",
        "> Have you ever done anything like this before?",
        "> How did you get started?",
        "> How did you feel when it was complete?",
        "> What made this time different from other times?",
        "> What is your favorite thing about this experience?",
        "> What did you learn about yourself through this experience?",
        "> How can you keep this experience in mind in the future?"
    };

    private List<string> _usedQuestions = new List<string>(); // Tracks used questions in the session

    public ReflectionActivity()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize your power and how you can use it in other aspects of your life.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            string question = GetNextQuestion(random);
            Console.WriteLine(question);
            ShowSpinner(5);
            elapsed += 5;
        }
    }

    private string GetNextQuestion(Random random)
    {
        // If all questions have been used, reset the list
        if (_usedQuestions.Count == _questions.Count)
        {
            _usedQuestions.Clear();
        }

        // Select a question that hasn't been used yet
        string question;
        do
        {
            question = _questions[random.Next(_questions.Count)];
        } while (_usedQuestions.Contains(question));

        _usedQuestions.Add(question); // Mark the question as used
        return question;
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