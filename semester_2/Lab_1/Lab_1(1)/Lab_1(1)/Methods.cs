using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_1_
{
    public class Methods : Candidate
    {
        public static void Top3ByPopularity(List<Candidate> candidates)
        {
            candidates.Sort((candidate1, candidate2) => candidate1.PopularityIndex.CompareTo(candidate2.PopularityIndex));
            Methods.PrintListOfCandidates(candidates);
        }
        public static void PartiasWhoSendCandidates(List<Candidate> candidates)
        {
            for (int i = 0; i < candidates.Count; i++)
            {
                if (candidates[i] != null)
                {
                    Console.WriteLine($"Partia: {candidates[i].partia}");

                }
            }
        }
        public static void PrintListOfCandidates(List<Candidate> candidates)
        {
            foreach (Candidate candidate in candidates)
            {
                Console.WriteLine(candidate.ToString());
            }
        }
        public static void AddCandidates(List<Candidate> candidates)
        {
            Candidate newCandidate = Create.CreateRandomCandidate();
            candidates.Add(newCandidate);
        }
        public static void RemoveCandidates(List<Candidate> candidates)
        {
            candidates.RemoveAt(candidates.Count - 1);
        }
        public static void ChangeInfoAboutCandidate(List<Candidate> candidates)
        {
            Methods.PrintListOfCandidates(candidates);
            Console.WriteLine("Which candidate you want to change?");
            int indexCandidate = int.Parse(Console.ReadLine());
            Candidate changedCandidate = candidates[indexCandidate - 1];
            Console.WriteLine("Which parameter of this candidate do you want to change?" +
                "(1 - PIB, 2 - Date of birth, 3 - Partia, 4 - Popularity index)");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Wnte a new PIB");
                    string? newPIB = Console.ReadLine();
                    candidates[indexCandidate - 1].PIB = newPIB;
                    break;
                case 2:
                    Console.WriteLine("Write a new date of birth");
                    string? newDateOfBirth = Console.ReadLine();
                    candidates[indexCandidate - 1].DateOfBirth = newDateOfBirth;
                    break;
                case 3:
                    Console.WriteLine("Write a new partia");
                    string? newPartia = Console.ReadLine();
                    candidates[indexCandidate - 1].Partia = newPartia;
                    break;
                case 4:
                    Console.WriteLine("Write a new popularity index");
                    int newPopularityIndex = int.Parse(Console.ReadLine());
                    candidates[indexCandidate - 1].PopularityIndex = newPopularityIndex;
                    break;
                default:
                    Console.WriteLine("try again");
                    break;

            }
        }
    }
}
