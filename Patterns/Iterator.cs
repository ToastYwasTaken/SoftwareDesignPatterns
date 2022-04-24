using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The iterator accesses elements of an aggregate object sequentially
/// You can easily access the IEnumerable as collection to iterate over
/// Example: List functions (Contains, Where, Count...), foreach-loops, Coroutines
/// Link: https://www.dofactory.com/net/iterator-design-pattern
/// </summary>

namespace SoftwareDesignPatterns.Patterns
{
    /// <summary>
    /// abstract interface to traverse elements
    /// </summary>
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
    }

    /// <summary>
    /// implements the Iterator interface
    /// keeps track of the current position of the aggregate
    /// </summary>
    public class ConcreteIterator : Iterator
    {
        Aggregate _aggregate;
        int _current = 0;
        public ConcreteIterator(Aggregate aggregate)
        {
            _aggregate = aggregate;
        }

        //Returns first object-element of the aggregate
        public override object First()
        {
            Console.WriteLine("Called 'First()' in ConcreteIterator");
            return _aggregate[0];
        }
        //Returns the next object-element of the aggregate, if in range
        public override object Next()
        {
            Console.WriteLine("Called 'Next()' in ConcreteIterator");
            object obj = null;
            if (_current < _aggregate.Count - 1)
            {
                obj = _aggregate[++_current];
            }
            return obj;
        }
    }

    /// <summary>
    /// Creates an Iterator over the aggregate
    /// </summary>
    public class Aggregate
    {
        List<object> _items = new List<object>();
        public Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        public int Count { get => _items.Count; }
        public object this[int index] { get => _items[index]; set => _items.Insert(index, value); }

    }

}
