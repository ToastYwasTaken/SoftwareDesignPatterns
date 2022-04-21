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
            return new ConcreteItemA(200, 1.8f, 1.0f);
        }

        public override Item FactoryMethodB()
        {
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

    }
    public class ConcreteItemA : Item
    {
        public ConcreteItemA(int value, float damageMult, float resistanceMult) : base(value, damageMult, resistanceMult)
        {
        }
    }
    public class ConcreteItemB : Item
    {
        public ConcreteItemB(int value, float damageMult, float resistanceMult) : base(value, damageMult, resistanceMult)
        {
        }
    }
}
