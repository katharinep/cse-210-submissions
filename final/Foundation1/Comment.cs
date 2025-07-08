public class Comment
{
    protected string _comment;
    protected string _userName;

    public Comment(string username, string comment)
    {
        _comment = comment;
        _userName = username;
    }

    public string DisplayComment()
    {
        return $"User name: {_userName}\nComment: {_comment}";
    }
}