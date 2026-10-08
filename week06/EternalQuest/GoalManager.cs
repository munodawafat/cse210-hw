using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _Goals;
        private int _Points;

        public GoalManager()
        {
            _Goals = new List<Goal>();
            _Points = 0;
        }

        public void AddGoal(Goal goal)
        {
            _Goals.Add(goal);
        }

        public void RecordEvent(int index)
        {
            if (index >= 0 && index < _Goals.Count)
            {
                Console.WriteLine("Invalid number");
                return;
            }
            int points = _Goals[index].RecordEvent();
            if (points == 0)
            {
                Console.WriteLine("No points earned.");
            }
            else 
            {
                _Points += points;
                Console.WriteLine($"Congratulations! You earned {_Points} points.");
                if (_Goals[index] is ChecklistGoal && _Goals[index].IsComplete())
                {
                    Console.WriteLine("Checklist goal COMPLETE -bonus awarded");
                }
                Console.WriteLine($"Your current score is: {_Points}");
            }
        }

         public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _Goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_Goals[i].GetPoints} {_Goals[i].GetName} ({_Goals[i].GetDescription})");
        }
        Console.WriteLine($"Score: {_Points} points\n");
    }

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_Points);
            foreach (Goal goal in _Goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Goals saved to {filename}");
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _Goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _Points = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal")
            {
                _Goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
            }
            else if (type == "EternalGoal")
            {
                _Goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "ChecklistGoal")
            {
                _Goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]),
                    int.Parse(data[4]), int.Parse(data[3]), int.Parse(data[5])));
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}
        