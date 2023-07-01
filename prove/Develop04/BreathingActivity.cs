class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void PerformBreathingActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine();

        Console.WriteLine("Get ready to breathe...");
        ShowSpinner(3);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);

            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
        ShowSpinner(4);
    }
}
