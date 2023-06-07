using System;

class Program
{
    static void Main(string[] args)
    {

        // DisplayWelcome - Displays the message, "Welcome to the Program!"

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        // PromptUserName - Asks for and returns the user's name (as a string)

        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }
        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)

        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }
        // DisplayResult - Accepts the user's name and the squared number and displays them.

        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"Hello {name}, your favorite number squared is {squaredNumber}!");
        }
        // Main - Calls the methods in the correct order.

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);

    }
} 
                 