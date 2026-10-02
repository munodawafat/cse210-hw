using System.Diagnostics;
using System.Reflection;

public class ReflectingActivity : Activity
{
    private readonly List<string> _Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Reflect on a time when you learned something valuable from a mistake.",
        "Consider a challenge you overcame and how it changed you.",
        "Think of a person who has influenced you in a positive way."
    };

    private readonly List<string> _Questions = new List<string>
    {
        "What was the situation?",
        "What did you feel when it happened?",
        "What did you learn from that experience?",
        "How has this experience shaped you?"
    };

    private readonly Random _random = new Random();

    public ReflectingActivity() : base("Reflecting", "Reflect on meaningful experiences and recognize your personal strength.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompts();
        DisplayQuestions();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_Prompts.Count);
        return _Prompts[index];
    }

    private string GetRandomQuestion()
    {
        int index = _random.Next(_Questions.Count);
        return _Questions[index];
    }

    private int GetDuration()
    {
        Type type = GetType().BaseType;

        while (type != null)
        {
            var property = type.GetProperty("Duration", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (property != null && property.PropertyType == typeof(int))
            {
                return (int)property.GetValue(this)!;
            }

            var method = type.GetMethod("GetDuration", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (method != null && method.ReturnType == typeof(int) && method.GetParameters().Length == 0)
            {
                return (int)method.Invoke(this, null)!;
            }

            type = type.BaseType;
        }

        return 0;
    }

    private void DisplayPrompts()
    {
        Console.WriteLine("Consider the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("When you have something in mind, press any key to continue...");
        Console.ReadLine();
    }

    private void DisplayQuestions()
    {
        var timer = Stopwatch.StartNew();
        while (timer.Elapsed.TotalSeconds < GetDuration())
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner();
            Console.WriteLine();
        }
    }
}