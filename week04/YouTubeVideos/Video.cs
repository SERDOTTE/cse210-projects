using System.Collections.Generic;

public class Video
{
    public string Title { get; set; } // Title of the video
    public string Author { get; set; } // Author of the video
    public int Duration { get; set; } // Duration of the video in seconds
    private List<Comment> _comments; // List of comments on the video

    // Constructor to initialize the video
    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
        _comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to get the list of comments
    public List<Comment> GetComments()
    {
        return _comments;
    }
}
