using System;

namespace H5Chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to H5Chocolate!");

            Chocolate chocolate = new Chocolate();
            chocolate.name = "Hockepulverchokladkaka";
            chocolate.cacaoAmount = 4;
            chocolate.milkAmount = 12;
            chocolate.filling.Add("Hockeypulver");
            chocolate.filling.Add("Havregryn");

            Console.WriteLine($"Chokladkakan {chocolate.name} har så här mycket kakao: {chocolate.cacaoAmount}.");
        }
    }
}
