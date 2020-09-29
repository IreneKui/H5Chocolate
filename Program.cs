using System;
using System.Collections.Generic;

namespace H5Chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to H5Chocolate!");

            List<Chocolate> chocolateDatabase = GenerateTestData();

            foreach (Chocolate c in chocolateDatabase)
            {
                Console.WriteLine($"Chokladkaka : {c.name}");
            }


            //Console.WriteLine($"Chokladkakan {chocolate.name} har så här mycket kakao: {chocolate.cacaoAmount}.");
        }
        private static List<Chocolate> GenerateTestData()
        {
            List<Chocolate> chocolateDatabase = new List<Chocolate>();
            Chocolate chocolate = new Chocolate();
            chocolate.name = "Hockeypulverchokladkaka";
            chocolate.cacaoAmount = 4;
            chocolate.milkAmount = 12;
            chocolate.filling.Add("Hockeypulver");
            chocolate.filling.Add("Havregryn");

            chocolateDatabase.Add(chocolate);

            Chocolate chocolate2 = new Chocolate();
            chocolate2.name = "Hasselnötschokladkaka";
            chocolate2.cacaoAmount = 4;
            chocolate2.milkAmount = 12;
            chocolate2.filling.Add("Hasselnötter");
            chocolate2.filling.Add("Havregryn");

            chocolateDatabase.Add(chocolate2);

            return chocolateDatabase;
        }
    }
}
