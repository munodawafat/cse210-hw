public class WritingAssignment : Assignment
{
    private string _Title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _Title = title;
    }
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_Title} by {studentName}";
    }
}