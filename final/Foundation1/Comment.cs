public class Comment
{
    private string _OSuserName;
    private string _OScomment;

    public Comment(string OSuserName, string OScomment)
    {
        _OSuserName = OSuserName;
        _OScomment = OScomment;

    }
    //GETTERS
    public string OSGetUserName()
    {
        return _OSuserName;
    }
    public string OSGetComment()
    {
        return _OScomment;
    }
}