using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Contains internal unique properties
/// Example: Audio- / Texturcatalogue, material settings, color palettes
/// Link: https://www.dofactory.com/net/flyweight-design-pattern
///       https://en.wikipedia.org/wiki/Flyweight_pattern
/// </summary>

namespace SoftwareDesignPatterns
{
    public class CarStore
    {
        public string carType;
        public List<CarsFlyweight> carStorage = new List<CarsFlyweight>();
        public CarStore()
        {
            Console.WriteLine("Adding SUV to storage:");
            carStorage.Add(FlyweightPointer.flyweightSUV);
            Console.WriteLine("Adding Lambo to storage:");
            carStorage.Add(FlyweightPointer.flyweightLambo);
            PrintCarStorage();
        }

        private void PrintCarStorage()
        {
            foreach (var car in carStorage)
            {
                Console.WriteLine($"Car: {car._Name} with ID [{car._ID}] costs {car._Price} $ and is painted {car._Color}");
            }
        }
    }

    /// <summary>
    /// Flyweight to help storing data for another class to avoid high RAM usage
    /// </summary>
    public class CarsFlyweight
    {
        public int _ID;
        public string _Name;
        public int _Price;
        public string _Color;
    }

    public static class FlyweightPointer
    {
        public static readonly CarsFlyweight flyweightSUV = new CarsFlyweight
        {
            _ID = 13210,
            _Name = "SUV",
            _Price = 12000,
            _Color = "red"
        };
        public static readonly CarsFlyweight flyweightLambo = new CarsFlyweight
        {
            _ID = 32190,
            _Name = "Lambo",
            _Price = 140000,
            _Color = "green"
        };
    }
}
