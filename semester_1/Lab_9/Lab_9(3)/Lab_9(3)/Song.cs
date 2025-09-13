using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_3_
{
    internal class Song
    {
        public string nameSong;
        public string pibAvtor;
        public string composer;
        public int year;
        public Songer[] songers;
        public Song()
        {
            nameSong = "";
            pibAvtor = "";
            composer = "";
            year = 0;
            songers = new Songer[0];
        }
        public Song(string nameSong, string pibAvtor, string composer, int year, Songer[] songers)
        {
            this.nameSong = nameSong;
            this.pibAvtor = pibAvtor;
            this.composer = composer;
            this.year = year;
            this.songers = songers;
        }
        public string NameSong
        {
            get { return nameSong; }
            set { nameSong = value; }
        }
        public string PibAvtor
        {
            get { return pibAvtor; }
            set { pibAvtor = value; }
        }
        public string Composer
        {
            get { return composer; }
            set { composer = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Songer[] Songers
        {
            get { return songers; }
            set { songers = value; }
        }
        public override string ToString()
        {
            return ($"Name of the song: {nameSong}, Avtors PIB: {pibAvtor}, Composer of the song: {composer}, Year of the song: {year}, Songers: {songers}");
        }

    }
}
