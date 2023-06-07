using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine();

        List<int> numbers = new List<int>();
        int yourInt = 1;
        int sum = 0;
        double average = 0; // Changed to double for more accurate average
        int max = 0;

        while (yourInt != 0)
        {
            Console.WriteLine("Enter a number or 0 to quit:");
            yourInt = int.Parse(Console.ReadLine());
            numbers.Add(yourInt);
        }

        Console.WriteLine();
        
        // Compute the sum, or total, of the numbers in the list.
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("The sum of the numbers is: " + sum);
        
        // Compute the average of the numbers in the list.
        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count; // Cast sum to double for accurate average
        }

        Console.WriteLine("The average of the numbers is: " + average);
        
        // Find the maximum, or largest, number in the list.
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine("The maximum number is: " + max);
    }
}
