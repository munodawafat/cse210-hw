public abstract class Goal
{
    protected string _Name;
    protected string _Description;
    protected int _Points;

    public Goal(string name, string description, int points)
    {
        _Name = name;
        _Description = description;
        _Points = points;
    }
    public string GetName()
    {
        return _Name;
    }
    public string SetName(string name)
    {
        _Name = name;
        return _Name;
    }
    public string GetDescription()
    {
        return _Description;
    }
    public string SetDescription(string description)
    {
        _Description = description;
        return _Description;
    }
    public int GetPoints()
    {
        return _Points;
    }
    public int SetPoints(int points)
    {
        _Points = points;
        return _Points;
    }
    public abstract bool IsComplete();

    public abstract int RecordEvent();

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();
}