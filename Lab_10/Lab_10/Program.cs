using System;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml.Serialization;

namespace Lab_10
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Candidate candidate1 = Create.CreateRandomCandidate();
            Candidate candidate2 = Create.CreateRandomCandidate();
            Candidate candidate3 = Create.CreateRandomCandidate();
            Candidate[] candidates = { candidate1, candidate2, candidate3 };
            foreach (Candidate candidate in candidates)
            {
                Console.WriteLine(candidate.ToString());
            }
            Console.WriteLine("Top 3 candidates by the popularity:");
            Candidate.Top3ByPopularity(candidates);
            Console.WriteLine("Parties that sent candidates:");
            Candidate.PartiasWhoSendCandidates(candidates);

            using (FileStream fs = new FileStream("Candidates.json", FileMode.Create))
            {
               await JsonSerializer.SerializeAsync<Candidate[]>(fs, candidates);
               Console.WriteLine("Data has been saved to file");
            }
            using (FileStream fs = new FileStream("Candidates.json", FileMode.Open))
            {
               Candidate[]? candidates2 = await JsonSerializer.DeserializeAsync<Candidate[]>(fs);
               for (int i = 0; i < candidates2.Length; i++)
               {
                   Console.WriteLine(candidates2[i].ToString());
               }
             
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Candidate[]));
            using (FileStream fs = new FileStream("Candidates.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, candidates);
                Console.WriteLine("Data has been saved to file");
            }

            using (FileStream fs = new FileStream("Candidates.xml", FileMode.Open))
            {
                Candidate[]? candidates3 = xmlSerializer.Deserialize(fs) as Candidate[];
                if (candidates3 != null)
                {
                    foreach (Candidate candidate in candidates3)
                    {
                        Console.WriteLine(candidate.ToString());
                    }
                }
            }
        }
    }
}
