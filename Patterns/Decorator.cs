using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// adds individual static or dynamic behaviour to an object
/// Example: Streams, Buffs in RPGs and MMOs, Unity components
/// Link: https://www.dofactory.com/net/decorator-design-pattern
/// </summary>

namespace SoftwareDesignPatterns.Patterns
{
    public abstract class Component
    {
        public abstract void Operation();
    }
    /// <summary>
    /// Default implementation of a component
    /// </summary>
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Called default 'Operation()' of 'ConcreteComponent'");
        }
    }

    /// <summary>
    /// Altered (/Decorated) implementation of Component as Decorator
    /// </summary>
    public abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            if (this._component != null)
            {
                this._component.Operation();
            }
            else Console.WriteLine(string.Empty);
        }
    }

    /// <summary>
    /// A decorator that can add funcionality / behaviour
    /// </summary>
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component)
        {

        }

        public override void Operation()
        {
            Console.WriteLine("Called decorated 'Operation()' of 'ConcreteDecorater'");
        }
    }
}
