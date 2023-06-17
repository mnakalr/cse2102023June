public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator(List<string> prompts)
    {
        _prompts = prompts;
        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int randomIndex = _random.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }
}