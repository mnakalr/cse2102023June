public class FileHandling
{
    public static void SaveEntries(string filename, List<string> entries)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (string entry in entries)
            {
                outputFile.WriteLine(entry);
            }
        }

        Console.WriteLine("Entries saved successfully.");
    }

    public static List<string> LoadEntries()
    {
        List<string> entries = new List<string>();

        string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");

        if (files.Length > 0)
        {
            Console.WriteLine("Available files:");
            for (int i = 0; i < files.Length; i++)
            {
                string fileName = Path.GetFileName(files[i]);
                Console.WriteLine($"{i + 1}. {fileName}");
            }

            Console.WriteLine("Enter the number of the file you want to load:");
            string input = Console.ReadLine();
            int selectedIndex;
            if (int.TryParse(input, out selectedIndex) && selectedIndex > 0 && selectedIndex <= files.Length)
            {
                string selectedFile = files[selectedIndex - 1];
                string[] lines = File.ReadAllLines(selectedFile);
                entries.AddRange(lines);
                Console.WriteLine("Entries loaded successfully.");
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
        else
        {
            Console.WriteLine("No entry files found in the current directory.");
        }

        return entries;
    }
}