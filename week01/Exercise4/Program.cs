using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        float average = ((float)sum) / numbers.Count;

        int largest = numbers[0];
        foreach (int n in numbers)
        {
            if (n > largest)
            {
                largest = n;
            }
        }

        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is: {largest}.");
    }
}