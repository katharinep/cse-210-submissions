public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentname, string topic, string _title) : base(studentname, topic)
    {
        studentname = _studentName;
        topic = _topic;
        string title = _title;
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic}\n{_title}";
    }
}