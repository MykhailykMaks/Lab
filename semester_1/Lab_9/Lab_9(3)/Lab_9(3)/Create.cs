using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_3_
{
    internal class Create
    {
        static Random random = new Random();
        public static string[] nameSongs = { "Believer", "Blinding Lights", "Shape of you", "Numb", "Rolling the deep" };
        public static string[] pibsAvtors = { "E.S.", "T.S.", "B.K.", "F.M.", "K.W." };
        public static string[] composers = { "Ludovico Einaudi", "Max Richter", "Hans Zimmer", "Hildur Gudnadouttir", "Ramin Djawadi" };
        public static int[] years = { 1980, 1990, 2000, 2010, 2020 };
        public static string[] pibsSongers = { "H.M", "E.K", "S.A", "B.G", "A.L" };
        public static int[] ageSongers = { 20, 25, 30, 40, 45 };

        public static string GetNameSong()
        {
            return (nameSongs[random.Next(nameSongs.Length)]);
        }
        public static string GetPIBAvtor()
        {
            return (pibsAvtors[random.Next(pibsAvtors.Length)]);
        }
        public static string GetComposers()
        {
            return (composers[random.Next(composers.Length)]);
        }
        public static string GetPIBSonger()
        {
            return (pibsSongers[random.Next(pibsSongers.Length)]);
        }
        public static int GetYear()
        {
            return (years[random.Next(years.Length)]);
        }
        public static int GetAgeSonger()
        {
            return (ageSongers[random.Next(ageSongers.Length)]);
        }
        public static Songer GetRandomSonger()
        {
            return new Songer(GetPIBSonger(), GetAgeSonger());
        }
        public static Song GetRandomSong()
        {
            return new Song(GetNameSong(), GetPIBAvtor(), GetComposers(), GetYear(), new Songer[0]);
        }
    }
}
