public class SimpleGoal : Goal
{
    private bool _IsComplete;

    public SimpleGoal(string name, string description, int points, bool complete = false) : base(name, description, points)
    {
        _IsComplete = complete;
    }

    public override int RecordEvent()
    {
        if (_IsComplete)
        {
            return 0;
        }
        _IsComplete = true;
        return _Points;
    }

    public override bool IsComplete()
    {
        return _IsComplete;
    }

    public override string GetDetailsString()
    {
        return $"[{(_IsComplete ? "X" : " ")}] {_Name} ({_Description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_Name}:{_Description}:{_Points}:{_IsComplete}";
    }
}