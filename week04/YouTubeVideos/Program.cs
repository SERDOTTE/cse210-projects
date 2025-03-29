using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create 3-4 videos with appropriate values
        Video video1 = new Video("Learning C# in VS Code", "BYU - Pathway", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Roberto", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Carlos", "I learned a lot!"));

        Video video2 = new Video("Top 10 Programming Languages", "U Academy", 900);
        video2.AddComment(new Comment("Diana", "Python is my favorite!"));
        video2.AddComment(new Comment("Bruce", "JavaScript all the way."));
        video2.AddComment(new Comment("Clark", "C# is underrated."));

        Video video3 = new Video("How to Build a Website", "WebDevPro", 1200);
        video3.AddComment(new Comment("Grace", "This was so detailed!"));
        video3.AddComment(new Comment("Tom", "I can finally build my own site."));
        video3.AddComment(new Comment("Peter", "Thanks for the tips!"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the list of videos and display their details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Duration: {video.Duration} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(); // Add a blank line between videos
        }
    }
}