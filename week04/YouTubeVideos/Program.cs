using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Introduction to Programming", "CSE110 Module", 120);
        video1.Comments.Add(new Comment("Trey", "This is exciting"));
        video1.Comments.Add(new Comment("Tank", "I understood it from the video"));
        video1.Comments.Add(new Comment("Lee", "The explanation was so clear"));

        Video video2 = new Video("Building a Website", "Web Developer", 600);
        video2.Comments.Add(new Comment("Lola", "This is how I learned to create my web page"));
        video2.Comments.Add(new Comment("Lester", "The steps are easy to follow"));
        video2.Comments.Add(new Comment("Simon", "I can design webs better after seeing these."));

        Video video3 = new Video("Programming with Classes", "Programming Academy", 820);
        video3.Comments.Add(new Comment("Lisa", "It's a bit complicated."));
        video3.Comments.Add(new Comment("Noa", "These video help a lot."));
        video3.Comments.Add(new Comment("Paul", "They should make more of them videos."));

        Video video4 = new Video("CSS Flex-box Basics", "Flex-box-MDN", 769);
        video4.Comments.Add(new Comment("Joshua", "I got a lot of practice flowing it."));
        video4.Comments.Add(new Comment("Trevor", "It challenged my brain"));
        video4.Comments.Add(new Comment("David", "It's far much easier than what I expected."));
       
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._Title}");
            Console.WriteLine($"Author: {video._Author}");
            Console.WriteLine($"Length: {video._Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"{comment._Name}: {comment._Text}");
            }

            Console.WriteLine();
        }
    }
}