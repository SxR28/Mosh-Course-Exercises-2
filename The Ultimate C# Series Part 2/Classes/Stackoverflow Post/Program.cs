using System;

namespace Stackoverflow_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var Voting = new Voting();
            Console.Write("Insert your name : ");
            string postName = Console.ReadLine();

            Console.Write("What is the title of your post : ");
            string postTitle = Console.ReadLine();

            Console.Write("Insert a description of your problem : ");
            string postDescription = Console.ReadLine();

            while (postName is string && postTitle is string && postDescription is string)
            {
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    Voting.UpVote(0);
                else if (Console.ReadKey().Key == ConsoleKey.P)
                    Voting.DownVote(0);

                Console.Clear();
                Console.WriteLine($"Name : {postName}\nTitle : {postTitle}\nDescription : {postDescription}\n\n - Up Votes : {Voting.totalUpVotes.Count}\n - Down Votes : {Voting.totalDownVotes.Count}");
            }
        }
    }
}
