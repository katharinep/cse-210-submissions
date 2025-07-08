public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment = new List<Comment>();
    private int _commentCount;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        //Console.WriteLine($"Number of Comments: {_commentCount}");
        //Console.WriteLine("Comments: ");
    }

    public void AddComment()
    {
        _comment.Add(comment);
    }
    public int CommentCount()
    {
        return 0;
    }
}