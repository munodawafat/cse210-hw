using System;
using System.Collections.Generic;

public class PromptsGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the most challenging part of your day?",
        "What was the best part of your day?",
        "Who made you smile today?",
        "What was the most interesting person you interacted with today?",
        "How did you see the hand of God in your life today?",
        "What are you grateful for?",
        "What was the strongest emotion you felt today?",
        "What did you learn today?",
        "What is something you want to improve about yourself?",
        "If you had one thing you could do over today, what would it be and why?"
    };
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    } 
}