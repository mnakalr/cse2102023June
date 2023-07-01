using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to the Mindfulness App!");

        // Create instances of different activities
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 10);
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.", 15);
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 20);

        // Initialize variables for activity counts
        int choice = 0;
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        // Main menu loop
        while (choice != 4)
        {
            // Display menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            // Perform the selected activity based on the user's choice
            if (choice == 1)
            {
                breathingActivity.PerformBreathingActivity();
                breathingCount++;
            }
            else if (choice == 2)
            {
                reflectionActivity.PerformReflectionActivity();
                reflectionCount++;
            }
            else if (choice == 3)
            {
                listingActivity.PerformListingActivity();
                listingCount++;
            }
            else if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine();
        }

        // Added the Activity log, which counts and displays the log. Exceed the requirements. 
        Console.WriteLine("Activity Log:");
        Console.WriteLine($"Breathing Activity: {breathingCount} times");
        Console.WriteLine($"Reflection Activity: {reflectionCount} times");
        Console.WriteLine($"Listing Activity: {listingCount} times");
    }
}
