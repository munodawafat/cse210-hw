using System;
using System.Collections.Generic;

public class Video
{
    public string _Title {get; set;}
    public string _Author {get; set;}
    public int _Length {get; set;}

    public List<Comment> Comments {get; set;}

    public Video(string title, string author, int length)
    {
        _Title = title;
        _Author = author;
        _Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return Comments.Count;
    }
}