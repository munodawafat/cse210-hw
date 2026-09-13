using System;

Journal journal = new Journal();
PromptsGenerator promptsGenerator = new PromptsGenerator();
string journalMenu = "1. Write Entry\n2. Display Entries\n3. Save to File\n4. Load from File\n5. Exit";
string userInput = "";

while (userInput != "5")
{
    Console.WriteLine(journalMenu);
    userInput = Console.ReadLine();

    if (userInput == "1")
    {
        string entryPrompt = promptsGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {entryPrompt}");
        Console.Write("Response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();
        Entry newEntry = new Entry(date, entryPrompt, response);
        journal.AddEntry(newEntry);
        Console.WriteLine("Entry added successfully!");
    }
    else if (userInput == "2")
    {
        journal.DisplayAll();
    }
    else if (userInput == "3")
    {
        Console.Write("Enter filename: ");
        string saveFilename = Console.ReadLine();
        journal.SaveToFile(saveFilename);
    }
    else if (userInput == "4")
    {
        Console.Write("Enter filename: ");
        string loadFilename = Console.ReadLine();
        try
        {
            journal.LoadFromFile(loadFilename);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
    else if (userInput != "5")
    {
        Console.WriteLine("Invalid option. Please try 1 - 5.");
        Console.WriteLine();
    }
}
