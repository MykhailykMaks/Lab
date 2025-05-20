using System.Collections.Immutable;
using System.ComponentModel;
using System.Reflection;

namespace Lab_7_1_
{
    enum TypeOfWork
    {
        Home, Business, Server
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer[] container1 = new Computer[3];
            container1[0] = RandomComputerCreate.GetRandomComputer();
            container1[1] = RandomComputerCreate.GetRandomComputer();
            container1[2] = RandomComputerCreate.GetRandomComputer();
            for (int i = 0; i < container1.Length - 1; i++)
            {
                for (int j = 0; j < container1.Length - i - 1; j++)
                {
                    string current = container1[j].Devices[0].NameOfDevice;
                    string next = container1[j + 1].Devices[0].NameOfDevice;

                    if (current.CompareTo(next) > 0)
                    {
                        Computer temp = container1[j];
                        container1[j] = container1[j + 1];
                        container1[j + 1] = temp;
                    }
                }
            }
            foreach (Computer computer in container1)
            {
                Console.WriteLine(computer.ToString());
            }
            container1[2].Add(RandomDeviceCreate.GetRandomDevice());
            for (int i = 0; i < container1.Length; i++)
            {
                container1[i].Save("computers1.txt");
            }
            Computer[] container2 = new Computer[3];
            for (int i = 0; i < 3; i++)
            {
                container2[i] = container1[i];
            }
            foreach (Computer computer in container2)
            {
                Console.WriteLine(computer.ToString());
            }
            for (int i = 0; i < container2.Length; i++)
            {
                container2[i].Save("computers2.txt");
            }
        }
    }
}