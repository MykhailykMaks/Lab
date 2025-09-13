namespace Lab1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] infoAboutFlight = File.ReadAllLines("Lab1_4.txt");
            double xFuel = double.Parse(infoAboutFlight[0]);
            double weight = double.Parse(infoAboutFlight[1]);
            double AB = double.Parse(infoAboutFlight[2]);
            double BC = double.Parse(infoAboutFlight[3]);
            int n = 0;
            if (weight > 0 && weight < 500)
            {
                n = 1;
            }
            else if (weight >= 500 && weight < 1000)
            {
                n = 4;
            }
            else if (weight >= 1000 && weight < 1500)
            {
                n = 7;
            }
            else if (weight >= 1500 && weight < 2000)
            {
                n = 9;
            }
            else
            {
                Console.WriteLine("Flight impossible");
            }
            double fuelForAB = AB * n;
            double fuelForBC = BC * n;
            if ((AB * n) <= xFuel)
            {
                xFuel -= fuelForAB;
                Console.WriteLine("Flight to B is successful");
                if(xFuel < fuelForBC)
                {
                    Console.WriteLine("We need a refuel");
                    double minRefuel = fuelForBC - xFuel;
                    xFuel += minRefuel;
                    Console.WriteLine($"Minimal refuel for this flight:{minRefuel}");
                }
                if ((BC * n) <= xFuel)
                {
                    Console.WriteLine("Flight to C is successful");
                }
                else
                {
                    Console.WriteLine("Flight to C is unsuccessful!!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Flight to B is unsuccessful!!");
                return;
            }
        }
    }
}
