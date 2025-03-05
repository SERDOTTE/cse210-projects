//Rodrigo Serdotte Freitas
using System;

class Program
{
    static void Main(string[] args)
    {
        // In case we determine the magic number
        //Console.WriteLine("Magic number Game");
        //Console.WriteLine("What is the magic number?");
        //int magicNumber = int.Parse(Console.ReadLine());

        // In case we generate a random number

        string playagain = "yes";
        while (playagain == "yes")
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int userGuess = -1;
            int count = 0; //Initialize the count variable
            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                count++; //Increment the count variable

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine("You took " + count + " attempts to guess the number!");
                    Console.WriteLine("Do you want to play again? (yes/no)");
                    playagain = Console.ReadLine();
                    if (playagain == "no")
                    {
                        Console.WriteLine("Goodbye!");
                    }
                }    
            }
        }
    }
}