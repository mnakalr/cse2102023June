class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Genesis", 1, 1);
        string text = "In the beginning God created the heaven and the earth.";
        Scripture scripture = new Scripture(reference, text);

        while (!scripture.AllTheWordAreHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.Display());
            Console.WriteLine("Press Enter to hide more words or press Backspace to exit.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                // Hide more words
                scripture.HideRandomWord();
            }
            else if (keyInfo.Key == ConsoleKey.Backspace)
            {
                // Exit the program
                break;
            }
            else
            {
                // Invalid key, handle accordingly
                Console.WriteLine("Invalid key.");
            }
        }
    }
}
