using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment done = new Assignment("Lukas Nakale", "Subtraction");
        Console.WriteLine(done.Getsummary());
        Console.WriteLine();

        // Create derived class objects
        MathAssignment mathx4 = new MathAssignment("Lukas Nakale", "Fractions","Section 7.3", "Problems 8-19");
        Console.WriteLine(mathx4.Getsummary());
        Console.WriteLine(mathx4.GetHomeworkList());
        Console.WriteLine();

        EnglishAssignment written = new EnglishAssignment("Lukas Nakale", "The infinite atonement", "the fall of adam and eve");
        Console.WriteLine(written.Getsummary());
        Console.WriteLine(written.GetWritingInformation());

        
    }
}