public class Comment
{
    public string Name { get; set; } // Name of the person who made the comment
    public string Text { get; set; } // Text of the comment

    // Constructor to initialize the comment
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}