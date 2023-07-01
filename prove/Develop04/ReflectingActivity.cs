class ReflectionActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void PerformReflectionActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine();

        Console.WriteLine("Think deeply about the following prompt:");
      

        string prompt = GetRandomPrompt();
        Console.WriteLine($"---{prompt}---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Get ready to reflect...");
        ShowSpinner(3);
        Console.WriteLine();

        Console.WriteLine("Reflect on the following questions:");
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            foreach (string question in _questions)
            {
                Console.WriteLine($"> {question}");
                ShowCountDown(6);
                
            }
        }
        Console.WriteLine();
        DisplayEndingMessage();
    }


    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Length);
        return _prompts[index];
    }
}
