using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Crazy Cat Antics", "CatLady123", 200);
        video1.AddComment(new Comment("Bob", "Cool video"));
        video1.AddComment(new Comment("catlover4ever", "OMG so funny"));
        video1.AddComment(new Comment("luckylou22", "Reminds me of my cat."));
        video1.CommentCount();
        video1.DisplayVideo();
        foreach (Comment comment in video1.GetComments())
        {
            Console.WriteLine(comment.DisplayComment());
        }
        Console.WriteLine("");

        Console.WriteLine("----------");
        Video video2 = new Video("Minecraft Tips", "ImmortalSteve", 620);
        video2.AddComment(new Comment("user389573", "Cool"));
        video2.AddComment(new Comment("MinecraftLover35658", "Can you do a video about redstone?"));
        video2.AddComment(new Comment("spiderman8459", "How do I get emeralds? I haven't found any. :()"));
        video2.CommentCount();
        video2.DisplayVideo();
        foreach (Comment comment in video2.GetComments())
        {
            Console.WriteLine(comment.DisplayComment());
        }
        Console.WriteLine("");

        Console.WriteLine("----------");
        Video video3 = new Video("Best Chocolate Cake Recipe Ever", "SassyBaker", 820);
        video3.AddComment(new Comment("ClaudineWilliams", "Looks so good!"));
        video3.AddComment(new Comment("LuAnn48593", "Yum!"));
        video3.AddComment(new Comment("TheRealSlimShady", "What are the measurements in metric?"));
        video3.CommentCount();
        video3.DisplayVideo();
        foreach (Comment comment in video3.GetComments())
        {
            Console.WriteLine(comment.DisplayComment());
        }
        Console.WriteLine("");
    }
}