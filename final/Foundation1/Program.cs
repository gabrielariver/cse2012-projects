using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video
        {
            Title = "C# Tutorial",
            Author = "CSharpMaster",
            Duration = 600
        };
        video1.AddComment("CoderGirl99", "Great tutorial, thanks!");
        video1.AddComment("ProgrammerX", "This video helped me a lot, keep it up!");
        video1.AddComment("Novice123", "I didn't understand the loops part, can someone explain?");
        videos.Add(video1);

        Video video2 = new Video
        {
            Title = "Introduction to ASP.NET",
            Author = "ASPNetGuru",
            Duration = 720
        };
        video2.AddComment("CodeNewbie", "Does anyone have more resources to learn ASP.NET?");
        video2.AddComment("ASPNetFan123", "Excellent explanation, thanks for sharing!");
        video2.AddComment("BeginnerCoder", "I'm a bit confused about controllers, any suggestions?");
        videos.Add(video2);

        Video video3 = new Video
        {
            Title = "Unity Tutorial",
            Author = "UnityPro",
            Duration = 480
        };
        video3.AddComment("UnityLover", "Loved it! What's your next tutorial?");
        video3.AddComment("GameDev2022", "How can I handle character physics?");
        video3.AddComment("UnityNewbie", "Can you make a tutorial on animations in Unity?");
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
