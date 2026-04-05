using System;

namespace TP_MODUL6_103022400029
{
    public class SayMusicTrack
    {
        // Fields (perhatikan: playCount adalah int, meskipun di gambar tertulis string – itu typo)
        private int id;
        private int playCount;   // diganti int karena akan di-increment
        private string title;

        // Random generator untuk ID 5 digit
        private static Random random = new Random();

        // Constructor
        public SayMusicTrack(string title)
        {
            // Generate id random 5 digit (10000 - 99999)
            id = random.Next(10000, 100000);
            this.title = title;
            playCount = 0;
        }

        // Method IncreasePlayCount
        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        // Method PrintTrackDetails
        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
            Console.WriteLine("-------------------------");
        }
    }
}