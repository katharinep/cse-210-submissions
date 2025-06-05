using System;
public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment(string studentname, string topic)
    {
        studentname = _studentName;
        topic = _topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetStudentName(string name)
    {
        _studentName = name;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}