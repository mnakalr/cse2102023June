class Video
{
    private string _title;
    private string _author;
    private TimeSpan _length;
    private List<Comment> _comments;

    public Video(string title, string author, TimeSpan length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of Comments: {_comments.Count}");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"Comment by {comment.GetAuthor()} on {comment.GetDate()}: {comment.GetText()}");
        }

        Console.WriteLine();
    }
}