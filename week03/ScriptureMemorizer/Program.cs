using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Main loop to keep the program running
        while (true)
        {
            // Load a random scripture from the file
            Scripture scripture = LoadRandomScripture("scriptures.txt");

            // Loop to display and replace words in the scripture
            while (true)
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("Press enter to continue or type 'quit' to exit.");

                // Read user input
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    return; // Exit the program
                }

                // Replace a random word in the scripture
                if (!scripture.ReplaceRandomWord())
                {
                    Console.Clear();
                    scripture.Display();
                    Console.WriteLine("ll words replaced. Press any key to continue.");
                    Console.ReadKey();
                    break; // Exit the inner loop
                }
            }

            // Ask the user if they want to memorize another scripture
            Console.WriteLine("Want to memorize another scripture? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                break; // Exit the main loop
            }
        }
    }

    // Method to load a random scripture from the file
    static Scripture LoadRandomScripture(string filePath)
    {
        // Read all lines from the file
        List<string> lines = new List<string>(File.ReadAllLines(filePath));
        Random random = new Random();
        int index = random.Next(lines.Count); // Get a random index
        string line = lines[index]; // Get the line at the random index

        // Split the line into reference and text parts
        string[] parts = line.Split('|');
        string referencePart = parts[0];
        string textPart = parts[1];

        Reference reference;
        // Check if the reference part contains a range of verses
        if (referencePart.Contains('-'))
        {
            // Split the reference into parts and create a Reference object
            string[] refParts = referencePart.Split(new char[] { ' ', ':', '-' });
            reference = new Reference(refParts[0], int.Parse(refParts[1]), int.Parse(refParts[2]), int.Parse(refParts[3]));
        }
        else
        {
            // Split the reference into parts and create a Reference object
            string[] refParts = referencePart.Split(new char[] { ' ', ':' });
            reference = new Reference(refParts[0], int.Parse(refParts[1]), int.Parse(refParts[2]));
        }

        // Return a new Scripture object with the reference and text
        return new Scripture(reference, textPart);
    }
}
