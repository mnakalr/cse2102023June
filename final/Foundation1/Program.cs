using System;
using System.Collections.Generic;


namespace Foundation1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Create some videos and comments
            Video video1 = new Video("Video 1", "Author 1", TimeSpan.FromMinutes(5));
            video1.AddComment(new Comment("Comment 1-1", "User1", DateTime.Now.AddMinutes(-30)));
            video1.AddComment(new Comment("Comment 1-2", "User2", DateTime.Now.AddMinutes(-20)));
            videos.Add(video1);

            Video video2 = new Video("Video 2", "Author 2", TimeSpan.FromMinutes(8));
            video2.AddComment(new Comment("Comment 2-1", "User3", DateTime.Now.AddMinutes(-10)));
            videos.Add(video2);

            // Display video details and comments
            foreach (Video video in videos)
            {
                video.DisplayVideoDetails();
            }
        }
    }
}


