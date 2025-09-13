namespace Lab_5
{
    enum TypeOfWork
    {
        Home, Business, Server
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = RandomComputerCreate.GetRandomComputer();
            Console.WriteLine(computer1.ToShortString());

            Console.WriteLine("Indexators");
            Console.WriteLine($"Home: {computer1[TypeOfWork.Home]}");
            Console.WriteLine($"Business: {computer1[TypeOfWork.Business]}");
            Console.WriteLine($"Server: {computer1[TypeOfWork.Server]}");

            computer1.Person = RandomPersonCreate.GetRandomPerson();
            computer1.IPaddress = RandomComputerCreate.GetRandomIpAddress();
            computer1.TypeOfWork = RandomComputerCreate.GetRandomTypeOfWork();
            computer1.AddDevices(new Device[] { RandomDeviceCreate.GetRandomDevice(), RandomDeviceCreate.GetRandomDevice(), RandomDeviceCreate.GetRandomDevice() });
            Console.WriteLine(computer1.ToString());

            Computer computer2 = RandomComputerCreate.GetRandomComputer();
            Computer computer3 = RandomComputerCreate.GetRandomComputer();
            Computer computer4 = RandomComputerCreate.GetRandomComputer();
            Computer computer5 = RandomComputerCreate.GetRandomComputer();
            Computer[] computers = { computer1, computer2, computer3, computer4, computer5 };

            computer2.IPaddress = RandomComputerCreate.GetRandomIpAddress();
            computer3.IPaddress = RandomComputerCreate.GetRandomIpAddress();
            computer4.IPaddress = RandomComputerCreate.GetRandomIpAddress();
            computer5.IPaddress = RandomComputerCreate.GetRandomIpAddress();
            Console.WriteLine("Computer`s IP addresses:");
            Console.WriteLine($"Computer 1: {computer1.IPaddress}\n, Computer 2: {computer2.IPaddress}\n, Computer 3: {computer3.IPaddress}\n, Computer 4: {computer4.IPaddress}\n, Computer 5: {computer5.IPaddress}");
        }
    }
}
