using System;

class Program
{
    static void Main(string[] args)
    {
        

        MathAssignment coding = new MathAssignment("Lukas Nakale", "Fractions","Section 7.3", "Problems 8-19");

        EnglishAssignment written = new EnglishAssignment("Lukas Nakale", "Work of the Lord", "Patience");


        Console.WriteLine(coding.Getsummary());
        Console.WriteLine(coding.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(written.Getsummary());
        Console.WriteLine(written.GetWritingInformation());

        
    }
}