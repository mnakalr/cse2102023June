using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());  
        Console.WriteLine("What is your guess? ");  
        int guess = int.Parse(Console.ReadLine());

        while (guess != magicNumber)
        {
            if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Too low!");
            }
            Console.WriteLine("What is your guess? ");  
            guess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"You guessed it! The magic number is: {magicNumber}");
    }
}