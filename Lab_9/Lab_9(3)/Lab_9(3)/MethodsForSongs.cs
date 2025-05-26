using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_3_
{
    class MethodsForSongs : Song
    {
        public static Song[] songs;
        static MethodsForSongs()
        {
            songs = new Song[0];
        }
        public static void AddSong(Song song)
        {
            Array.Resize(ref songs, songs.Length + 1);
            songs[songs.Length - 1] = song;
        }
        public static void DeleteSong(Song song)
        {
            Song[] newSongers = new Song[songs.Length - 1];
            int index = Array.IndexOf(songs, song);
            int j = 0;
            if (index >= 0)
            {
                for (int i = 0; i < songs.Length; i++)
                {
                    if (i != index)
                    {
                        newSongers[j] = songs[i];
                        j++;
                    }
                }
            }
            songs = newSongers;
        }
        public void NewInfoSong(string newNameSong = "", string newPIBAvtor = "", string newComposer = "", int newYear = 0, Songer[]? newSongers = null)
        {
            nameSong = newNameSong;
            pibAvtor = newPIBAvtor;
            composer = newComposer;
            year = newYear;
            songers = newSongers;
        }
        public static void SearchSongByName(string nameSong)
        {
            foreach (var song in songs)
            {
                if (song.NameSong == nameSong)
                {
                    Console.WriteLine(song.ToString());
                    return;
                }
            }
            Console.WriteLine("Song not found.");
        }
        public static void SearchSongByYear(int year)
        {
            foreach (var song in songs)
            {
                if (song.Year == year)
                {
                    Console.WriteLine(song.ToString());
                    return;
                }
            }
            Console.WriteLine("Song not found.");
        }
        public static void SaveSongsToFile(Song[] songs)
        {
            using (StreamWriter writer = new StreamWriter("saveSongs.txt"))
            {
                foreach (var song in songs)
                {
                    writer.WriteLine(song.ToString());
                }
            }
        }
        public static void LoadSongsFromFile(Song[] songs)
        {
            using (StreamReader reader = new StreamReader("loadSongs.txt"))
            {
                string lines;
                while ((lines = reader.ReadLine()) != null)
                {
                    string[] parts = lines.Split(',');
                    if (parts.Length >= 4)
                    {
                        string nameSong = parts[0].Split(':')[1].Trim();
                        string pibAvtor = parts[1].Split(':')[1].Trim();
                        string composer = parts[2].Split(':')[1].Trim();
                        int year = int.Parse(parts[3].Split(':')[1].Trim());
                        AddSong(new Song(nameSong, pibAvtor, composer, year, null));
                    }
                }
            }
        }
        public static void FindSongsBySongerPIB(Song[] songs, string searchPIB)
        {
            foreach (var song in songs)
            {
                foreach (var songer in song.Songers)
                {
                    if (songer.pibSonger.Equals(searchPIB))
                    {
                        Console.WriteLine($"Songer {searchPIB} sing song: {song.NameSong}");
                    }
                }
            }
        }

    }
}
