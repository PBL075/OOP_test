using System;

namespace Robot
{
    class Program
    {
        static void Main()
        {
         Robot bot = new Robot();
         bot.name = "Bot";
         bot.weight = 800;
         bot.coordinates = new byte[] {0, 0, 0};

         Console.WriteLine(bot.name + "weight: " + bot.weight); 

         Robot killer = new Robot();
         killer.weight = 1000 ;
         killer.name = "Killer";
         killer.coordinates = new byte[] {0, 0, 10};  
         Console.WriteLine(killer.name + " weight: " + killer.weight);
        }
    }
}
