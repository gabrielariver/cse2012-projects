using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; }
    private List<Comment> comments = new List<Comment>();

    public void AddComment(string commenterName, string text)
    {
        Comment comment = new Comment(commenterName, text);
        comments.Add(comment);
    }

    public int NumComments()
    {
        return comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Duration: " + Duration + " seconds");
        Console.WriteLine("Number of comments: " + NumComments());
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine("Commenter: " + comment.CommenterName);
            Console.WriteLine("Comment: " + comment.Text);
        }
        Console.WriteLine();
    }
}
