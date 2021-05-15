using System;
using System.Linq;
using WiredBrainCoffeeShop.DataAccess;

namespace WiredBrainCoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to WiredBrain Coffee Shop. Your number one Coffee Shop.");
            Console.WriteLine("Write 'help' to list available Coffee Shop commands.Write 'quite' to Exit.");
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
                else 
                {
                    coffeeShops = coffeeShops.Where(x => x.Location.StartsWith(line,StringComparison.OrdinalIgnoreCase)).ToList();
                    if(coffeeShops.Count() == 0)
                    {
                        Console.WriteLine($"> command {line} is not found");
                    }
                    else if (coffeeShops.Count() == 1)
                    {
                        var coffeeShop = coffeeShops.First();
                        Console.WriteLine($"> Location: {coffeeShop.Location}");
                        Console.WriteLine($"> Beans in stock: {coffeeShop.BeansInStockInKg} in Kg");
                    }
                    else 
                    {
                        Console.WriteLine($"Multple matching command for {line} was found:");
                        foreach(var coffeeShop in coffeeShops)
                        {
                            Console.WriteLine($"> {coffeeShop.Location}");
                        }
                    }
                }
            }
        }
    }
}
