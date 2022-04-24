using System;
using System.Collections.Generic;
/// <summary>
/// The Observer observes many Subjuect to notify all dependents
/// when one object changes state
/// Example: Events / EventHandling, 
/// </summary>

namespace SoftwareDesignPatterns.Patterns
{
    /// <summary>
    /// The observer is the 'managing' instance that notifies all 
    /// subjects when changes occured in one subscribing object
    /// </summary>
    public class Observer
    {
        public string _name;
        public string _observerState;
        public static int _instancesCount = 0;
        private ConcreteSubject _subject;
        public Observer(ConcreteSubject subject, string name)
        {
            _subject = subject;
            _name = name;
            _instancesCount++;
        }

        public void UpdateObserver()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine($"Observer {_name}'s new state is [{_observerState}]");
        }
        public ConcreteSubject Subject { get => _subject;  set => _subject = value;  }
    }
    /// <summary>
    /// The subject knows its observers.
    /// Provides interfaces to subscribe / unsubscribe
    /// </summary>
    public abstract class Subject
    {
        public string _name;
        private List<Observer> _observers = new List<Observer>();
        public void Subscribe(Observer observer)
        {
            Console.WriteLine($"Adding observer {observer._name}...");
            _observers.Add(observer);
        }
        public void Unsubscribe(Observer observer)
        {
            Console.WriteLine($"Removing observer {observer._name}...");
            _observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                Console.WriteLine($"Notifying observer {observer._name}...");
                observer.UpdateObserver();
            }
        }
    }

    /// <summary>
    /// Sends a notification to the obsercers when its state is changed
    /// </summary>
    public class ConcreteSubject : Subject
    {
        public static int _instancesCount = 0;
        private string _subjectState;
        public ConcreteSubject(string name)
        {
            _name = name;
            _instancesCount++;
        }
        public string SubjectState { get => _subjectState; set => _subjectState = value; }

    }
}
