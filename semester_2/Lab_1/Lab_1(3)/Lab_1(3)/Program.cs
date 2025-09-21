namespace Lab_1_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numberOfUsers = 5;
            var printQueue = new PriorityQueue<User, int>();
            for (int i = 0; i < numberOfUsers; i++)
            {
                User newUser = Create.CreateRandomUser();
                printQueue.Enqueue(newUser, newUser.Priority);
                Console.WriteLine($"{newUser.ToString()}");
            }

            List<Print> completedRequests = new List<Print>();
            string printFilePath = "Test.txt";
            File.WriteAllText(printFilePath, string.Empty);

            while (printQueue.TryDequeue(out User? user, out int priority))
            {
                DateTime endingTime = DateTime.Now;
                Print request = new Print(user.PIB, priority, user.Time, endingTime);
                completedRequests.Add(request);
                string printText = ($"User {user.PIB} with priority {priority} created his request on: {user.Time}, and we completed it on: {endingTime}\n");
                File.AppendAllText(printFilePath, printText);
            }
            foreach (var request in completedRequests)
            {
                Console.WriteLine(request.ToString());
            }
        }
    }
}
