using System;

class Program
{
    static void Main(string[] args)
    {   
        int marks = 0;
        string letter = "";
        Console.WriteLine("Enter your marks: ");
        marks = Convert.ToInt32(Console.ReadLine());
        string Message = "You failed. Better luck next time!";
        
        if (marks >= 90)
        {
            letter = "A";
            Message = "Congradulation, you passed!";
        }
        else if (marks >= 80)
        {
            letter = "B";
            Message = "Congradulation, you passed!";
        }
        else if (marks >= 70)
        {
            letter = "C";
            Message = "Congradulation, you passed!";
        }
        else if (marks >= 60)
        {
            letter = "D";
        }
        else if (marks >= 50)
        {
            letter = "E";
        }
        else if (marks < 50)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine(Message);
        }
        Console.WriteLine($"Your grade is: {letter}!");
        Console.WriteLine(Message);
    }
}