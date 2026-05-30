using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Exploring the Carrefour supermarket", "Dimitrix", 120);
        video1.AddComment(new Comment("Thomas Gomez", "Incredible prices, the cheapest and best quality appliances for summer."));
        video1.AddComment(new Comment("Miguel Gauna", "Gaming computers with excellent installment payment options starting at $20 USD."));
        video1.AddComment(new Comment("Anshelo Paz", "Hair clippers 50% off when you buy two, many still available!!!"));
        video1.AddComment(new Comment("Enzo Marcos", "Do you know if they offer a trade-in program? I have a used TV, and I'd like to trade it in."));

        Video video2 = new Video("Exploring the Dia supermarket", "Mr. Savings", 180);
        video2.AddComment(new Comment("Marcos Perez", "Incredible prices!!."));
        video2.AddComment(new Comment("Nancy Garcia", "Gaming computers $20 US c/u."));
        video2.AddComment(new Comment("Axel Frattoni", "Excelent prices."));

        Video video3 = new Video("Exploring the Yaguar supermarket", "Kings", 240);
        video3.AddComment(new Comment("Estrella Peralta", "Good video."));
        video3.AddComment(new Comment("Elias Martin", "Excellent products for resale."));
        video3.AddComment(new Comment("Jose Rivera", "The school supply kits are of good quality"));
        video3.AddComment(new Comment("Lautaro Gimenez", "I bought a 2024 model washing machine for $60, highly recommended."));

        Video video4 = new Video("Exploring the Cotto supermarket", "Steven YT", 300);
        video4.AddComment(new Comment("Angel Rivas", "The cheapest and best quality!!"));
        video4.AddComment(new Comment("Santiago Correa", "What are the opening hours on weekends?"));
        video4.AddComment(new Comment("Ruben Rodriguez", "I'm planning to go this week!!"));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video element in videos)
        {
            Console.WriteLine($"Title: {element.GetTitle()}");
            Console.WriteLine($"Author: {element.GetAuthor()}");
            Console.WriteLine($"Duration: {element.GetDuration()} seg");
            Console.WriteLine($"Number of Comments: {element.GetNumberOfComments()}");
            Console.WriteLine();

            List<Comment> list = element.GetComments();
            Console.WriteLine("Comments below");

            foreach (Comment comment in list)
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine("__________  __________  __________  __________  __________  __________  __________  __________  __________  __________  _________");
        }
        
    }
}