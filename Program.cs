using System;

namespace TP_MODUL6_103022400029
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Mencoba membuat track dengan judul null...");
                SayMusicTrack trackNull = new SayMusicTrack(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception tertangkap: {ex.Message}");
            }

            try
            {
                Console.WriteLine("\nMencoba judul terlalu panjang (101 karakter)...");
                string longTitle = new string('A', 101);
                SayMusicTrack trackLong = new SayMusicTrack(longTitle);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception tertangkap: {ex.Message}");
            }

            SayMusicTrack track = new SayMusicTrack("Valid Title");
            try
            {
                Console.WriteLine("\nMencoba menambah play count 20.000.000 (melebihi 10 juta)...");
                track.IncreasePlayCount(20000000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception tertangkap: {ex.Message}");
            }

            Console.WriteLine("\nMenguji overflow dengan loop...");
            SayMusicTrack trackOverflow = new SayMusicTrack("Overflow Test");
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    trackOverflow.IncreasePlayCount(int.MaxValue / 500); // menambah nilai besar
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception tertangkap: {ex.Message}");
            }

            Console.WriteLine("\nHasil akhir track:");
            trackOverflow.PrintTrackDetails();

            Console.WriteLine("\nTekan sembarang tombol...");
            Console.ReadKey();
        }
    }
}