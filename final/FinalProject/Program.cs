using System;
using System.Collections.Generic;

using Foundation1;
namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runPrograms = true;

            while (runPrograms)
            {
                Console.WriteLine("Select a Foundation program to run:");
                Console.WriteLine("1. Foundation 1");
                Console.WriteLine("2. Foundation 2");
                Console.WriteLine("3. Foundation 3");
                Console.WriteLine("4. Foundation 4");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Running Foundation 1:");
                        Foundation1.Program.Main(args); // Call the Main() method from the Foundation1 project
                        break;
                    case "2":
                        Console.WriteLine("Running Foundation 2:");
                        Foundation2.Program.Main(args); // Call the Main() method from the Foundation2 project
                        break;
                    case "3":
                        Console.WriteLine("Running Foundation 3:");
                        Foundation3.Program.Main(args); // Call the Main() method from the Foundation3 project
                        break;
                    case "4":
                        Console.WriteLine("Running Foundation 4:");
                        //add reference to Foundation4 project
                        //how to add reference to Foundation4 project
                        Foundation4.Program.Main(args); // Call the Main() method from the Foundation4 project
                        break;
                    case "5":
                        runPrograms = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }

}
