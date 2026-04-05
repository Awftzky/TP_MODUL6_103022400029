using System;
using System.Diagnostics;   // Debug.Assert

namespace TP_MODUL6_103022400029
{
    public class SayMusicTrack
    {
        private int id;
        private int playCount;
        private string title;
        private static Random random = new Random();

        public SayMusicTrack(string title)
        {
            Debug.Assert(title != null, "Judul track tidak boleh null");
            
            Debug.Assert(title.Length <= 100, "Judul track maksimal 100 karakter");
            
            id = random.Next(10000, 100000);
            this.title = title;
            playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Penambahan play count maksimal 10.000.000");
            
            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Terjadi overflow: {ex.Message}");
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
            Console.WriteLine("-------------------------");
        }
    }
}