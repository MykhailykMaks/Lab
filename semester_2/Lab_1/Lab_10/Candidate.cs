using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    public class Candidate
    {
        public string pib;
        public string dateOfbirth;
        public string partia;
        public int popularityIndex;

        public Candidate(string pib, string dateOfbirth, string partia, int popularityIndex)
        {
            this.pib = pib;
            this.dateOfbirth = dateOfbirth;
            this.partia = partia;
            this.popularityIndex = popularityIndex;
        }
        public Candidate()
        {
            pib = "";
            dateOfbirth = "";
            partia = "";
            popularityIndex = 0;
        }
        public string PIB
        {
             get { return pib; }
             set { pib = value; }
        }
        public string DateOfBirth
        {
            get { return dateOfbirth; }
            set { dateOfbirth = value; }
        }
        public string Partia
        {
            get { return partia; }
            set { partia = value; }
        }
        public int PopularityIndex
        {
            get { return popularityIndex; }
            set { popularityIndex = value; }
        }
        public static void Top3ByPopularity(Candidate[] candidates)
        {
            Array.Sort(candidates, (a, b) => b.PopularityIndex.CompareTo(a.PopularityIndex));
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(candidates[i].ToString());
            }
        }
        public static void PartiasWhoSendCandidates(Candidate[] candidates)
        {
            for(int i = 0; i < candidates.Length; i++)
            {
                if (candidates[i] != null)
                {
                    Console.WriteLine($"Partia: {candidates[i].partia}");

                }
            }
        }
        public override string ToString()
        {
            return $"Last name, Name, Father`s name: {PIB}, Date of birth: {dateOfbirth}, Candidate`s partia: {partia}, Index of popularity: {popularityIndex}";
        }
    }
}
