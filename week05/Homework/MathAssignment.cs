public class MathAssignment : Assignment
{
    private string _TextbookSection;
    private string _Problems;
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _TextbookSection = textbookSection;
        _Problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_TextbookSection} Problems {_Problems}";
    }
}