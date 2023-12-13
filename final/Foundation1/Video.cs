public class Video
{
    private string _OSauthor;
    private string _OStitle;
    private int _OSlength;
    private List<Comment> _OScomments;

    public Video(string OSauthor, string OStitle, int OSlength)
    {
        _OSauthor = OSauthor;
        _OStitle = OStitle;
        _OSlength = OSlength;
        _OScomments = new List<Comment>();
    }
    public void OSAddComment(string OSauthor, string OScomment)
    {
        Comment OSnewComment = new Comment(OSauthor, OScomment);
        _OScomments.Add(OSnewComment);
    }
    public void OSDisplayVideoInfo()
    {
        Console.WriteLine("\n--- VIDEO INFO ---");
        Console.WriteLine($"Title: {_OStitle}");
        Console.WriteLine($"Author: {_OSauthor}");
        Console.WriteLine($"Lenght in seconds: {_OSlength}");
        Console.WriteLine($"Number of comments: {OSGetCommentsCount()}");
    }
    public void OSDisplayVideoComments()
    {
        Console.WriteLine("\n--- COMMENTS ---");
        foreach (Comment OScomment in _OScomments)
        {
            Console.WriteLine($"{OScomment.OSGetUserName()}\n {OScomment.OSGetComment()}");
        }
    }

    //GETTERS
    public string OSGetAuthor()
    {
        return _OSauthor;
    }
    public string OSGetTitle()
    {
        return _OStitle;
    }
    public int OSGetLenght()
    {
        return _OSlength;
    }
    public int OSGetCommentsCount()
    {
        return _OScomments.Count();
    }
}