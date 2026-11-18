using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a list to hold all the videos
            List<Video> videos = new List<Video>();

            // --- Video 1 ---
            Video video1 = new Video("Learn C# in 10 Minutes", "CodeWithJohn", 600);
            video1.AddComment(new Comment("Alice", "This was incredibly helpful, thanks!"));
            video1.AddComment(new Comment("Bob", "I finally understand classes now."));
            video1.AddComment(new Comment("Charlie", "Great pace. Can you do one on inheritance?"));
            videos.Add(video1);

            // --- Video 2 ---
            Video video2 = new Video("Top 10 Healthy Breakfasts", "FitLife", 450);
            video2.AddComment(new Comment("Diana", "The overnight oats look amazing."));
            video2.AddComment(new Comment("Ethan", "I tried the avocado toast, it was perfect."));
            video2.AddComment(new Comment("Fiona", "What about vegan options?"));
            video2.AddComment(new Comment("George", "Loved the background music!"));
            videos.Add(video2);

            // --- Video 3 ---
            Video video3 = new Video("SpaceX Starship Launch Highlights", "SpaceNews", 1200);
            video3.AddComment(new Comment("Hannah", "The landing was flawless!"));
            video3.AddComment(new Comment("Ian", "So inspiring to watch humanity push boundaries."));
            video3.AddComment(new Comment("Julia", "Can't wait for the next test flight."));
            videos.Add(video3);

            // --- Video 4 ---
            Video video4 = new Video("How to Bake Sourdough Bread", "BakingWithSarah", 850);
            video4.AddComment(new Comment("Kevin", "My starter finally worked thanks to this!"));
            video4.AddComment(new Comment("Laura", "The crumb on that loaf is beautiful."));
            video4.AddComment(new Comment("Mike", "Do I need a Dutch oven for this?"));
            videos.Add(video4);

            // 2. Iterate through the list of videos and display the required info
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.GetTitle()}");
                Console.WriteLine($"Author: {video.GetAuthor()}");
                Console.WriteLine($"Length: {video.GetLength()} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");

                // Iterate through the comments for this video
                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"  - {comment.GetCommenterName()}: {comment.GetText()}");
                }

                // A blank line for readability between videos
                Console.WriteLine(); 
            }
        }
    }
}