public class Video
{
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
}