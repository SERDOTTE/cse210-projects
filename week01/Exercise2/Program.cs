//Rodrigo Serdotte Freitas
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();

        //verify if the input is a number
        if (!int.TryParse(answer, out int grade))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string signal = "";

        //void applying signs for grade 'F'
        if (grade >= 60)
        {
            int remainder = grade % 10;

            if (remainder >= 7)
            {
                signal = "+";
            }
            else if (remainder <= 3)
            {
                signal = "-";
            }
            
        }

        Console.WriteLine($"Your grade is {letter}{signal}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("You failed! Better luck next time!");
        }
    }
}