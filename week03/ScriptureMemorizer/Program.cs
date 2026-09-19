using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all your heart and lean not on your own understanding;"));
        scriptures.Add(new Scripture(new Reference("Philippians", 4, 13), "I can do all this through him who gives me strength."));
        scriptures.Add(new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd, I lack nothing."));
        scriptures.Add(new Scripture(new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."));

        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        Scripture randomScripture = scriptures[randomIndex];

        //Main loop to hide words and display the scripture
        while (!randomScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(randomScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input?.ToLower() == "quit")
            {
                break;
            }
            // Hide 2 random words from the scripture
            randomScripture.HideRandomWords(2);
            Console.Clear();
            Console.WriteLine(randomScripture.GetDisplayText());
        }
    }
}

class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int Verse { get; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    public override string ToString() => $"{Book} {Chapter}:{Verse}";
}

class Word
{
    private readonly string _text;
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        _text = text;
    }

    public void Hide() => IsHidden = true;

    public string GetDisplayText() => IsHidden ? "_____" : _text;
}

class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;
    private readonly Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => new Word(word))
            .ToList();
    }

    public string GetDisplayText()
    {
        return $"{_reference}: {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = _words.Where(word => !word.IsHidden).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden() => _words.All(word => word.IsHidden);
}