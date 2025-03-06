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
            Console.Write("Enter a number: ");
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

        int? smallestPositive = null;
        foreach (int n in numbers)
        {
            if (n > 0 && (smallestPositive == null || n < smallestPositive))
            {
                smallestPositive = n;
            }
        }

        // Sort the list
        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average:F3}.");  
        Console.WriteLine($"The largest number is: {largest}.");
        if (smallestPositive.HasValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}.");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }

        //Display the sorted list 
        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}