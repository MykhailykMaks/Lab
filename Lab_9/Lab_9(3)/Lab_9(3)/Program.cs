namespace Lab_9_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = Create.GetRandomSong();
            Song song2 = Create.GetRandomSong();
            Song song3 = Create.GetRandomSong();
            Song[] songs1 = { song1, song2, song3 };
            Song[] songs2 = new Song[0];
            foreach (var song in songs1)
            {
                Console.WriteLine(song.ToString());
            }
            Song song4 = Create.GetRandomSong();
            MethodsForSongs.AddSong(song4);
            Console.WriteLine("After adding a new song:");
            foreach (var song in songs1)
            {
                Console.WriteLine(song.ToString());
            }
            MethodsForSongs.DeleteSong(song4);
            Console.WriteLine("After deleting the song:");
            foreach (var song in songs1)
            {
                Console.WriteLine(song.ToString());
            }
            MethodsForSongs.SearchSongByName(song1.NameSong);
            MethodsForSongs.SearchSongByYear(song2.Year);
            foreach (var song in songs1)
            {
                Console.WriteLine(song.ToString());
            }
            if (song1.Songers.Length > 0)
            {
                MethodsForSongs.FindSongsBySongerPIB(songs1, song1.Songers[0].pibSonger);
            }
            MethodsForSongs.SaveSongsToFile(songs1);
            MethodsForSongs.LoadSongsFromFile(songs2);
            foreach (var song in songs2)
            {
                Console.WriteLine(song.ToString());
            }

        }
    }
}
