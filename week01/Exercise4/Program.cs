using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userImput = -1;

        while (userImput != 0)
        {
            Console.Write("Enter number ");
            userImput = int.Parse(Console.ReadLine());

            if (userImput != 0)
            {
                numbers.Add(userImput);
            }

        }
        // Calculate total and average
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"Total: {total}");

        double average = Convert.ToDouble(total) / numbers.Count;

        Console.WriteLine($"Average {average}");

        // Calculate largest number

        int largest = numbers[0];

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        Console.WriteLine($"Largest number: {largest}");
    }
}