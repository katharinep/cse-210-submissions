public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textbooksection, string problems, string studentname, string topic) : base(studentname, topic)
    {
        _textbookSection = textbooksection;
        _problems = problems;
        _studentName = studentname;
        _topic = topic;
    }

    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}\nSection {_textbookSection} Problems {_problems}";
    }
}