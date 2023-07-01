class ListingActivity : Activity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void PerformListingActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine();

        Console.WriteLine("Get ready to list...");
        ShowSpinner(3);
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt:");

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine();

        Console.WriteLine("Start listing items in:");
        ShowCountDown(4);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                count++;
        }

        Console.WriteLine($"You listed {count} items.");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Length);
        return _prompts[index];
    }
}
