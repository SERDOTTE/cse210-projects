using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0); // 3 miles in 30 minutes
        Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 45, 15.0); // 15 mph for 45 minutes
        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 20, 30); // 30 laps in 20 minutes

        // Add activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}