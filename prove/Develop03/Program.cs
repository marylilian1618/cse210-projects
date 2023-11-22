using System;

class Program
{
    static void Main(string[] args)
    {
        // Creamos una nueva instancia de scripture, la cual fue pasada en scripture.cs
        //como un constructor con dos tipo de data: la referencia y la escritura
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world...");

        // Display the complete scripture
        DisplayScripture(scripture);

        // Prompt the user to press enter or type quit
        while (true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (string.Equals(input, "quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            // Hide random words
            HideRandomWords(scripture);

            // Display the modified scripture
            DisplayScripture(scripture);

            if (scripture.AllWordsHidden)
            {
                Console.WriteLine("All words hidden. Press Enter to exit.");
                break;
            }
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine($"Scripture: {scripture.Reference}");
        Console.WriteLine(scripture.GetVisibleText());
    }

    static void HideRandomWords(Scripture scripture)
    {
        Random random = new Random();
        List<Word> visibleWords = scripture.Words.Where(w => !w.IsHidden).ToList();

        if (visibleWords.Count > 0)
        {
            Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
        }
    }
}
    