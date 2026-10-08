using System.Drawing;

public class ChecklistGoal : Goal
{
    private int _AmountCompleted;
    private int _Target;
    private int _Bonus;
   

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0) : base(name, description, points)
    {
        _Target = target;
        _Bonus = bonus;
        _AmountCompleted = amountCompleted;
    }
    public override int RecordEvent()
    {
        if (_AmountCompleted >= _Target)
        {
            return 0;
        }
        _AmountCompleted++;
        
        if (_AmountCompleted == _Target)
        {
            return _Points + _Bonus;
        }
    }    
    public override bool IsComplete()
    {
        return _AmountCompleted >= _Target;
    }

    public override string GetDetailsString()
    {
        String box = IsComplete() ? "[x]" : "[ ]";
        return $"{box}  Completed {_AmountCompleted}/{_Target} times.";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_Name}, {_Description}, {_Points}, {_Target}, {_AmountCompleted}, {_AmountCompleted}/{_Target},{_Bonus}";
    }
}