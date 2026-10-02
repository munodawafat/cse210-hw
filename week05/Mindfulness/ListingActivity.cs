using System.Diagnostics;

namespace Mindfulness;

public class ListingActivity : Activity
{
    private List<string> _Prompts;
    private int _Count;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _Prompts = new List<string>
        {
            "things in your home",
            "people you appreciate",
            "activities that make you happy",
            "things you are grateful for",
            "things that bring you peace"
        };
    }

    public void Run()
    {
        Console.WriteLine("Welcome to the Listing Activity!");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.Write("How long, in seconds, would you like your session to last? ");

        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Please enter a valid positive number of seconds: ");
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();

        Console.WriteLine($"Prompt: {GetRandomPrompt()}");
        var items = GetListFromUser(duration);
        Console.WriteLine($"You listed {_Count} items.");
    }

    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_Prompts.Count);
        return _Prompts[index];
    }

    private List<string> GetListFromUser(int duration)
    {
        Console.WriteLine("Please list as many items as you can in the given area:");
        var items = new List<string>();
        _Count = 0;
        var timer = Stopwatch.StartNew();
        while (timer.Elapsed.TotalSeconds < duration)
        {
            var remaining = duration - (int)timer.Elapsed.TotalSeconds;
            Console.WriteLine($"You have {remaining} seconds left. Enter an item (or press Enter to finish):");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
            items.Add(input);
            _Count++;
        }
        return items;
    }
}