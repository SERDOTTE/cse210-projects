using System;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "What are three things you are grateful for today?",
        "Who is someone in your life that you are grateful for?",
        "What is a recent experience that brought you joy?",
        "What is something about yourself that you are grateful for?",
        "What is a place that makes you feel happy or peaceful?"
    };

    public GratitudeActivity()
        : base("Gratitude", "This activity will help you reflect on the things you are grateful for in your life. Gratitude can improve your mood and overall well-being.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine("Take a moment to reflect on the following prompt:");
        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");
        ShowSpinner(5); // Pause for 5 seconds to let the user reflect

        Console.WriteLine("Now, write down your thoughts:");
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

        Console.WriteLine($"Thank you for reflecting on gratitude!. You listad {count} items!");
    }
}