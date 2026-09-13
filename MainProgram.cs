
using System;

namespace TravelApp.Models
{
    public class Tour
    {
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }

    public class Client
    {
        public string Name { get; set; } = string.Empty;
    }
}

namespace TravelApp
{
    using TravelApp.Models;

    class Program
    {
        static void Main(string[] args)
        {
            Tour tour1 = new Tour()
            {
                Country = "Італія",
                City = "Рим",
                Price = 25000
            };

            Tour tour2 = new Tour()
            {
                Country = "Японія",
                City = "Токіо",
                Price = 68000
            };

            Client client1 = new Client()
            {
                Name = "Василь Тодорюк"
            };

            Client client2 = new Client()
            {
                Name = "Оксана Бойко"
            };

            Console.WriteLine("=== ТУРИСТИЧНА АГЕНЦІЯ ===");
            
            Console.WriteLine("\nТуристичні пропозиції:");
            Console.WriteLine($"1. {tour1.Country}, м. {tour1.City} — {tour1.Price} грн");
            Console.WriteLine($"2. {tour2.Country}, м. {tour2.City} — {tour2.Price} грн");

            Console.WriteLine("\nКлієнти:");
            Console.WriteLine($"1. {client1.Name}");
            Console.WriteLine($"2. {client2.Name}");
        }
    }
}
