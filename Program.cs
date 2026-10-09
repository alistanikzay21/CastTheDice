using System;
using System.Collections.Generic;

namespace CastTheDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Tärningsspelet!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Målet med spelet är att slå två tärningar och få summan 12.");
            Console.WriteLine("Om du får summan 12 vinner du spelet!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Tryck på valfri tangent för att börja spela.");
            Console.ReadKey();

          Random random = new Random(); 
          string playagain = "ja";

          while (playagain == "ja")
{

          int dice1 = random.Next(1,7);
          int dice2 = random.Next(1,7);

          int sum = dice1 + dice2;

          Console.WriteLine($"Tärning 1: {dice1}"); 
          Console.WriteLine("-------------------");
          Console.WriteLine($"Tärning 2: {dice2}");
          Console.WriteLine("-------------------");
          Console.WriteLine($"Summan av tärningarna: {sum}");
          Console.WriteLine("-------------------");

        if (sum == 12)
{
          Console.WriteLine("Grattis! Du har vunnit!");

    }
        else
{
          Console.WriteLine("Tyvärr, du har inte vunnit den här gången.");
          Console.WriteLine("------------------------------------------");
}
          Console.WriteLine("Vill du spela igen? (ja/nej)");
          playagain = (Console.ReadLine() ?? "").ToLower();

}
         Console.WriteLine("-------------------------------");
         Console.WriteLine("Tack för att du spelade!");
         Environment.Exit(0);

        }
    }
}