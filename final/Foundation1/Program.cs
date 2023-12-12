using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Hello world","Lilian Inga",1400);
        video1.AddComment("Susan", "Amazing video. I loved it!");
        video1.AddComment("Pedro","Too bored. Didn't like it.");
        video1.AddComment("Lilian", "My video looks amazing!");

        Video video2 = new Video("Salad is delicious","Mitchell Gomez",1500);
        video2.AddComment("Lita", "Too much pepper:( )");
        video2.AddComment("Juan","Such a delicious meal.");
        video2.AddComment("Steve", "Love salad!");

        Video video3 = new Video("Picnic with friends","Maroon Lanazca",1000);
        video3.AddComment("Sue", "Hahaha loved maccaroni");
        video3.AddComment("Raul","It was funny.");
        video3.AddComment("Loki", "I am hungry right now");

        List<Video> videoList = new List<Video> { video1, video2, video3 };
        foreach (Video video in videoList)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumComments()}");

            if (video.GetNumComments() > 0)
            {
                Console.WriteLine("Comments:");
                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($"  {comment.GetName()}: {comment.GetComment()}");
                }
            }

            Console.WriteLine();
    }
    }}
