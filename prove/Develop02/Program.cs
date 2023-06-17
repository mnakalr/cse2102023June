using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // List of prompts for journal entries
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        // Create a new journal
        Journal journal = new Journal();

        int choice = 0;
        string saveFilename = "entries.txt";

        while (choice != 5)
        {
            // Display menu
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Entries");
            Console.WriteLine("4. Load Entries");
            Console.WriteLine("5. Exit");
            Console.WriteLine("What do you want to do?");

            // Read user's choice
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid choice.");
                continue;
            }

            // Process user's choice
            switch (choice)
            {
                case 1:
                    // Create a new entry and write it
                    Entry newEntry = new Entry();
                    newEntry.WriteEntry(prompts);
                    journal.AddEntry(newEntry);
                    break;
                case 2:
                    // Display all journal entries
                    journal.DisplayEntries();
                    break;
                case 3:
                    //First check if there are any entries to save
                    if (journal.Entries.Count == 0)
                    {
                        Console.WriteLine("No entries to save.");
                    }
                    else
                    {
                        // Prompt user for filename 
                        Console.WriteLine("Enter the filename to save the entries:");
                        saveFilename = Console.ReadLine();

                        //this adds ".txt" so that the user does not have to worry about it.
                        if (!saveFilename.EndsWith(".txt"))
                        {
                            saveFilename += ".txt";
                        }

                        //This will save the entries as a list of strings
                        List<string> entriesToSave = new List<string>();
                        foreach (Entry entry in journal.Entries)
                        {
                            entriesToSave.Add(entry._theEntry);
                        }
                        FileHandling.SaveEntries(saveFilename, entriesToSave);
                    }
                    break;
                case 4:
                    // Load entries from a directory and display them for user to choose the file the wish to load
                    List<string> loadedEntries = FileHandling.LoadEntries();
                    journal = new Journal();
                    foreach (string entryText in loadedEntries)
                    {
                        Entry loadedEntry = new Entry();
                        loadedEntry._theEntry = entryText;
                        journal.AddEntry(loadedEntry);
                    }
                    //Display entries loaded
                    journal.DisplayEntries();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid menu option.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
