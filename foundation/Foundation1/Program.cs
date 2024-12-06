using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        //create 3-4 videos
        Video video1 = new Video("Cutest Cat EVER!", "CrazeeCatDad", 180);
        Video video2 = new Video("Frog Sporn", "LtD", 300);
        Video video3 = new Video("Never Do This! Hamster Version", "H-Mom", 230);
        Video video4 = new Video("I Thought I Could Handle a Bee", "Waxy Master", 1080);

        //add comments to the videos
        video1.AddComment("SpongeBob Pants II", "ADORABLE!! Snails are cute, too ;-)");
        video1.AddComment("Nopa Dopa", "I went on vacation to Switzerland. It was okay.");
        video1.AddComment("Totes Adorbz", "OMG I'M DYING");
        video1.AddComment("D. Ork", "I don't really like cats. or dogs. but cats rule and dogs drewl");

        video2.AddComment("Frog Fanatik", "I like frogs.");
        video2.AddComment("Woopsie Daisie", "I never knew sporn until I met you.");
        video2.AddComment("R. BIt", "ribbit ribbit");
        video2.AddComment("BeearMan", "Bud. Wise. Errrrrrrrrrrrr");

        video3.AddComment("M.G. Reals", "No way! I wear pink on Wednesdays, too!!!");
        video3.AddComment("Steve's Journey", "Wheels in the sky keep on turnin'");
        video3.AddComment("Ded Hamster", "Oh shoot, i wish i wouldve watched this earlier");
        
        video4.AddComment("Punny Gui", "2 B or not 2 B - THAT isthequestion");
        video4.AddComment("D.Who", "The bees disappearing really had me stumped for a bit there.");
        video4.AddComment("Wild Bill", "Could you handle a quarterack running, passing, and receiving a touchdown in a single game? THAT'S how you handle it.");

        //add each video to a list
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);
        _videos.Add(video4);

        //iterate through the list of videos
        foreach (Video video in _videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Video Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine();
        }
    }        
}