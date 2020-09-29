using System;
using System.Collections.Generic;

namespace H5Chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Chocolate> chocolateDatabase = GenerateTestData();

            Order order = new Order();  //Object

            Console.Clear();
            Console.WriteLine("---Welcome to H5Chocolate Console Ordering System!---");
            
            while(true)
            {
                Console.WriteLine("Välj en produkt: ");
    
                foreach (Chocolate c in chocolateDatabase)  //Loop
                {
                    Console.WriteLine($"[{chocolateDatabase.IndexOf(c)}]: {c.name}");
                }
                Console.WriteLine("[B] Lägg beställning");
                Console.WriteLine("[A] Avsluta");

                Console.Write("Val: ");
                string input = Console.ReadLine().ToUpper();

                if(input == "B")
                {
                    bool orderSuccessful = order.Confirm();
                    if(orderSuccessful)
                    {
                        Console.WriteLine("Beställning skickad! Tack!!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Något gick fel, har du lagt till choklad?");
                        Console.ResetColor();
                    }                
                continue;
                }
                else if (input == "A")
                {
                    Environment.Exit(0);
                }
                int index = Convert.ToInt32(input);
                order.AddChocolate(chocolateDatabase[index]);

                Console.WriteLine($"Du har beställt: {order.GetOrderList()}");
                Console.WriteLine("----------------------------------------");

            //Console.WriteLine($"Chokladkakan {chocolate.name} har så här mycket kakao: {chocolate.cacaoAmount}.");

            }
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
