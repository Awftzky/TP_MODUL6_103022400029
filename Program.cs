using System;

namespace TP_MODUL6_103022400029
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek SayMusicTrack
            SayMusicTrack track = new SayMusicTrack("Bohemian Rhapsody");
            
            // Menambah play count
            track.IncreasePlayCount(100);
            track.IncreasePlayCount(50);
            
            // Cetak detail
            track.PrintTrackDetails();
            
            Console.WriteLine("Tekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}