using System;
using WiredBrainCoffeeShop.DataAccess;

namespace WiredBrainCoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to WiredBrain Coffee Shop. Your number one Coffee Shop.");
            Console.WriteLine("Write 'help' to list all available Coffee Shop commands");
            var coffeeShopDataProvider = new CoffeeShopDataProvider();

            while (true)
            {
                var line = Console.ReadLine();
                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShop();

                if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available Coffee Commands:");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> {coffeeShop.Location}");
                    }
                }    
            }
        }
    }
}
