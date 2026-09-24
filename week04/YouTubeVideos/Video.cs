using System.Collections.Generic;

public class Video
{
    public string _Title {get; set;}
    public string _Author {get; set;}
    public int _Length {get; set;}

    public List<Comment> Comments {get; set;}

    public Video(string title, string author, int length)
    {
        title = _Title;
        author = _Author;
        length = _Length;
        Comments = new List<Comment>();
    }
    public int GetCommentCount()
    {
        return Comments.Count;
    }
}