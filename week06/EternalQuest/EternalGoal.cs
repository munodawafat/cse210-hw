public class EternalGoal : Goal
{
    public EternalGoal()
    {}
    public override int RecordEvent()
    {
        return 0;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        return "";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}