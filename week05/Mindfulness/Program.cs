using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity"); // New activity added
            Console.WriteLine("5. Activity Statistics"); // New option for statistics
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Start();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Start();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Start();
            }
            else if (choice == "4")
            {
                GratitudeActivity gratitude = new GratitudeActivity();
                gratitude.Start();
            }
            else if (choice == "5") // Option to display activity statistics
            {
                Console.Clear();
                Console.WriteLine("Activity Statistics:");
                Console.WriteLine($"Breathing Activity: {BreathingActivity.GetTimesCompleted()} times completed");
                Console.WriteLine($"Reflection Activity: {ReflectionActivity.GetTimesCompleted()} times completed");
                Console.WriteLine($"Listing Activity: {ListingActivity.GetTimesCompleted()} times completed");
                Console.WriteLine($"Gratitude Activity: {GratitudeActivity.GetTimesCompleted()} times completed");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (choice == "6") // Quit option
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.ReadLine();
            }
        }
    }
}