using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.Clear();

            // Display total points
            Console.WriteLine($"You have {goalManager.GetTotalPoints()} points.\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a Choice from menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                if (goalType == "1")
                {
                    goalManager.AddGoal(new SimpleGoal(name, description, points));
                }
                else if (goalType == "2")
                {
                    goalManager.AddGoal(new EternalGoal(name, description, points));
                }
                else if (goalType == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goalManager.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                }
            }
            else if (choice == "2")
            {
                goalManager.DisplayGoals();
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to save goals (e.g., goals.txt): ");
                string filename = Console.ReadLine();

                // Ensure the filename ends with .txt
                if (!filename.EndsWith(".txt"))
                {
                    filename += ".txt";
                }

                goalManager.SaveGoals(filename);
                Console.WriteLine("Goals saved successfully. Press Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load goals: ");
                string filename = Console.ReadLine();
                goalManager.LoadGoals(filename);
                Console.WriteLine("Goals loaded successfully. Press Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                goalManager.DisplayGoals();
                Console.Write("Enter the number of the goal to record: ");
                int goalIndex = int.Parse(Console.ReadLine()) - 1;
                goalManager.RecordEvent(goalIndex);
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
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