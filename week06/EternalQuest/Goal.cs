public abstract class Goal
{
    protected string _Name;
    protected string _Description;
    protected int _Points;

    public abstract int RecordEvent();

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();
}