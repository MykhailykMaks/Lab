using System.Security.Cryptography;
using System.Text;

namespace Lab2_3
{
    internal class Program
    {
        static void FirstLvl()
        {
            int health, maxHealth = 5;
            int myPoints = 0;
            int pcPoints = 0;
            int round = 1;
            int maxRound = 3;
            for (int i = 0; i < maxRound; i++)
            {
                health = 5;
                Console.WriteLine($"Round{round}:");
                Random rand = new Random();
                int randNumber = rand.Next(1, 10);
                do
                {
                    Console.WriteLine($"You have {health} healths");
                    Console.Write("Try to guess a number:\n");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess == randNumber)
                    {
                        Console.WriteLine("You win!");
                        myPoints += health * 5;
                        Console.WriteLine($"You have {myPoints} points");
                        Console.Write("Do you want a play in 2 level?(1 - yes, 2 - no)");
                        int forSecondLvl = int.Parse(Console.ReadLine());
                        switch (forSecondLvl)
                        {
                            case 1:
                                SecondLvl();
                                return;
                            case 2:
                                break;
                        }
                        ++round;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("OOOppppsssss, you didn't guess");
                        --health;
                        if (health <= 0)
                        {
                            pcPoints += maxHealth * 5;
                            Console.WriteLine("You lose!!!");
                            Console.WriteLine($"Computer steal your {pcPoints} points");
                            ++round;
                            break;
                        }
                        Console.WriteLine($"You have {health} healths");
                        Console.Write("Do you want a help?:(1 - Yes, i want, 2 - No)\n");
                        int Pr = Convert.ToInt32(Console.ReadLine());
                        switch (Pr)
                        {
                            case 1:
                                --health;
                                if (guess > randNumber)
                                {
                                    Console.WriteLine("The hidden number less than your guess");
                                    if (health <= 0)
                                    {
                                        pcPoints += maxHealth * 5;
                                        Console.WriteLine("You lose!!!");
                                        Console.WriteLine($"Computer steal your {pcPoints} points");
                                        ++round;
                                        break;
                                    }
                                    break;
                                }
                                else
                                {
                                    if (health <= 0)
                                    {
                                        pcPoints += maxHealth * 5;
                                        Console.WriteLine("You lose!!!");
                                        Console.WriteLine($"Computer steal your {pcPoints} points");
                                        ++round;
                                        break;
                                    }
                                    Console.WriteLine("The hidden number larger than your guess");
                                    break;
                                }
                            case 2:
                                if (health <= 0)
                                {
                                    pcPoints += maxHealth * 5;
                                    Console.WriteLine("You lose!!!");
                                    Console.WriteLine($"Computer steal your {pcPoints} points");
                                    ++round;
                                    break;
                                }
                                Console.WriteLine("No so no, try again");
                                break;
                        }
                        
                    }
                } while (health > 0);
            }
        }
        static void SecondLvl()
        {
            int health, maxHealth = 25;
            int myPoints = 0;
            int pcPoints = 0;
            int round = 1;
            int maxRound = 2;
            for (int i = 0; i < maxRound; i++)
            {
                health = 25;
                Console.WriteLine($"Round{round}:");
                Random rand = new Random();
                int randNumber = rand.Next(10, 100);
                do
                {
                    Console.WriteLine($"You have {health} healths");
                    Console.Write("Try to guess a number:\n");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess == randNumber)
                    {
                        Console.WriteLine("You win!");
                        myPoints += health * 10;
                        Console.WriteLine($"You have {myPoints} points");
                        ++round;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("OOOppppsssss, you didn't guess");
                        --health;
                        if (health <= 0)
                        {
                            pcPoints += maxHealth * 10;
                            Console.WriteLine("You lose!!!");
                            Console.WriteLine($"Computer steal your {pcPoints} points");
                            ++round;
                            break;
                        }
                        Console.WriteLine($"You have {health} healths");
                        Console.Write("Do you want a help?:(1 - Yes, i want, 2 - No)\n");
                        int Pr = Convert.ToInt32(Console.ReadLine());
                        switch (Pr)
                        {
                            case 1:
                                --health;
                                if (guess > randNumber)
                                {
                                    Console.WriteLine("The hidden number less than your guess");
                                    if (health <= 0)
                                    {
                                        pcPoints += maxHealth * 10;
                                        Console.WriteLine("You lose!!!");
                                        Console.WriteLine($"Computer steal your {pcPoints} points");
                                        ++round;
                                        break;
                                    }
                                    break;
                                }
                                else
                                {
                                    if (health <= 0)
                                    {
                                        pcPoints += maxHealth * 10;
                                        Console.WriteLine("You lose!!!");
                                        Console.WriteLine($"Computer steal your {pcPoints} points");
                                        ++round;
                                        break;
                                    }
                                    Console.WriteLine("The hidden number larger than your guess");
                                    break;
                                }
                            case 2:
                                if (health <= 0)
                                {
                                    pcPoints += maxHealth * 10;
                                    Console.WriteLine("You lose!!!");
                                    Console.WriteLine($"Computer steal your {pcPoints} points");
                                    ++round;
                                    break;
                                }
                                Console.WriteLine("No so no, try again");
                                break;
                        }

                    }
                } while (health > 0);
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Lets start our game!!!");
            FirstLvl();
        }
    }
}
