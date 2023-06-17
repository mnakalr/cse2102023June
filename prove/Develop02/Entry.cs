public class Entry
{
    public string _theEntry { get; set; }

    public void WriteEntry(List<string> prompts)
    {
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();

        PromptGenerator promptGenerator = new PromptGenerator(prompts);
        string randomPrompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine(randomPrompt);
        string response = Console.ReadLine();

        _theEntry = $"Date: {dateText} - Prompt: {randomPrompt}\n{response}";
    }

    public void Display()
    {
        Console.WriteLine(_theEntry);
    }
}
