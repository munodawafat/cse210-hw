public class SimpleGoal : Goal
{
    private bool _IsComplete;

    public override int RecordEvent()
    {
        return 0;
    }

    public override bool _IsComplete()
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