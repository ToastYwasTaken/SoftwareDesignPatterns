using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Generates instances of an object without specifying the type
/// Example: Dynamic lootpools, RTS factory 
/// Link: https://www.dofactory.com/net/factory-method-design-pattern
/// </summary>

namespace SoftwareDesignPatterns.Patterns
{
    public abstract class LootPoolGenerator
    {
        public abstract Item FactoryMethodA();
        public abstract Item FactoryMethodB();
    }

    /// <summary>
    /// Hold 2 different factory methods to create new Items
    /// </summary>
    public class ConcreteLootPoolGenerator : LootPoolGenerator
    {
        public override Item FactoryMethodA()
        {
            Console.WriteLine("Creating new concrete Item A");
            return new ConcreteItemA(200, 1.8f, 1.0f);
        }

        public override Item FactoryMethodB()
        {
            Console.WriteLine("Creating new concrete Item B");
            return new ConcreteItemB(140, 1.0f, 2.2f);
        }
    }
    
    public abstract class Item
    {
        public int _value;
        public float _damageMultiplier;
        public float _resistanceMultiplier;

        public Item(int value, float damageMult, float resistanceMult)
        {
            _value = value;
            _damageMultiplier = damageMult;
            _resistanceMultiplier = resistanceMult;
        }

        public void PrintItem()
        {
            Console.WriteLine($"Item with value: [{_value}] damage multiplier: [{_damageMultiplier}] resistance multiplier: [{_resistanceMultiplier}]");
        }

    }
    /// <summary>
    /// A concrete item with certain stat-boosts
    /// </summary>
    public class ConcreteItemA : Item
    {
        public ConcreteItemA(int value, float damageMult, float resistanceMult) : base(value, damageMult, resistanceMult)
        {
        }
    }
    /// <summary>
    /// A concrete item with certain stat-boosts
    /// </summary>
    public class ConcreteItemB : Item
    {
        public ConcreteItemB(int value, float damageMult, float resistanceMult) : base(value, damageMult, resistanceMult)
        {
        }
    }
}
