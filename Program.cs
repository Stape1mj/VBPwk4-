using System;
using System.Threading;

namespace VBP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vacation Budget Planner! What is your name?");
            string name = Console.ReadLine();
            string password = "trip";

            Console.WriteLine("What is the password?");
            string userInput = Console.ReadLine();
            int attempts = 1;
            while (userInput == password && attempts <=3)
            {
                

                Console.WriteLine("\r\nHi " + name + "! Where would you like to go?\r\nMexico or Jamaica?");
                string ans = Console.ReadLine().ToLower();


                switch (ans)
                {
                    case "mexico":
                        Console.WriteLine("\r\nGreat, Mexico sounds like an amazing trip!\r\n**********");
                        Console.WriteLine("\r\nHow many days do you plan to stay there?");
                        int daysM = Int32.Parse(Console.ReadLine());
                        int hrsM = (daysM * 24);
                        int minM = (hrsM * 60);
                        Console.WriteLine("\r\nOk, so based on my calculations, that would be " + hrsM + " hours and " + minM + " minutes. Impressed yet?");
                        Console.WriteLine("\r\nHow much $$$ do you plan on bringing?");
                        double money = double.Parse(Console.ReadLine());
                        double peso = money * 20.19;
                        double pesoDaily = Math.Round((peso / daysM), 2);
                        double usdDaily = Math.Round((money / daysM), 2);
                        Console.WriteLine("You would have " + pesoDaily + " pesos or " + usdDaily + " dollars per day to spend");


                        break;

                    case "jamaica":
                        Console.WriteLine("\r\nGreat, Jamaica sounds like an amazing trip!\r\n**********");
                        Console.WriteLine("\r\nHow many days do you plan to stay there?");
                        int daysJ = Int32.Parse(Console.ReadLine());
                        int hrsJ = (daysJ * 24);
                        int minJ = (hrsJ * 60);
                        Console.WriteLine("\r\nOk, so based on my calculations, that would be " + hrsJ + " hours and " + minJ + " minutes. Impressed yet?");
                        Console.WriteLine("\r\nHow much $$$ do you plan on bringing?");
                        double moneyJ = double.Parse(Console.ReadLine());
                        double jD = moneyJ * 154.02;
                        double jdDaily = Math.Round((daysJ / jD), 2);
                        double usddailyJ = Math.Round((moneyJ / daysJ), 2);
                        Console.WriteLine("You would have " + jdDaily + " Jamaican Dollars or " + usddailyJ + " dollars per day to spend");
                        break;

                    default:
                        Console.WriteLine("You misunderstood. Try again.");
                        break;
                }
            }
            while (attempts <= 3 && userInput != password)
            {
                Console.WriteLine("try again");
                attempts++;
                Console.ReadLine();
            }
             if (attempts > 3)
            {
                Console.WriteLine("Unauthorized user. Initiate self-destruct sequence in 5...");
                Thread.Sleep(1000);
                Console.WriteLine("4...");
                Thread.Sleep(1000);
                Console.WriteLine("3...");
                Thread.Sleep(1000);
                Console.WriteLine("2...");
                Thread.Sleep(1000);
                Console.WriteLine("1...");
                Thread.Sleep(1000);
                Console.WriteLine("Goodbye");
            }
        }
    }
}
