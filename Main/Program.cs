using SoftwareDesignPatterns.Patterns;
using System;

/// <summary>
/// Test all patterns here
/// Find all patterns at: https://www.dofactory.com/net
/// </summary>

namespace SoftwareDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Singleton
            ////create Singleton
            //Singleton single1 = new Singleton();

            ////now anytime there can be only one instance of 'single' 
            ////when trying to create (a) new instance(s), nothing happens
            ////the original instance stays, a new one doesn't get instantiated
            //Singleton single2 = Singleton.GetInstance();
            #endregion
            #region Composite
            //Console.WriteLine();
            ////create root
            //Directory root = new Directory("root");

            ////create folders
            //Directory folderMovies = new Directory("movies");
            //Directory folderSeries = new Directory("series");

            ////add folders to root
            //root.Add(folderMovies);
            //root.Add(folderSeries);

            ////add movies to the movies-folder
            //folderMovies.Add(new FileItem("Bat Man: The Dark Knight", 1200000));
            //folderMovies.Add(new FileItem("American Psycho", 2400000));

            ////add series to the series-folder
            //folderSeries.Add(new FileItem("How i met your mother", 400000));
            //folderSeries.Add(new FileItem("The Big Bang Theory", 400000));

            ////add subdirectory
            //Directory folderHorrorMovies = new Directory("horror movies");
            //folderHorrorMovies.Add(new FileItem("Shining", 180000));
            //folderHorrorMovies.Add(new FileItem("The Conjuring", 180000));

            ////add subdirectory(horror movies) to major directory(folderMovies)
            //folderMovies.Add(folderHorrorMovies);
            #endregion
            #region Builder
            ////Console.WriteLine();
            ////create new Director instance
            //PlayerDirector director = new PlayerDirector();

            //////Start() instantiates a new PlayerBuilder -> the PlayerBuilder adds all step-by-step methods of the Builder
            //director.Start();
            #endregion
            #region Decorator
            //Console.WriteLine();
            ////Creating simple concrete component
            //Console.WriteLine("Simple Concrete Component:");
            //ConcreteComponent concreteComponent = new ConcreteComponent();
            //concreteComponent.Operation();

            ////Creating concrete decorator of component
            //Console.WriteLine("Decorated component:");
            //ConcreteDecorator concreteDecorator = new ConcreteDecorator(concreteComponent);
            //concreteDecorator.Operation();
            #endregion
            #region FactoryMethod
            ////Example for a LootpoolGenerator with dynamic Items
            ////Create a concrete loot-pool generator
            //ConcreteLootPoolGenerator lootPoolGenerator = new ConcreteLootPoolGenerator();

            ////Call the methods to start instantiating new Items
            ////Display the generated Item
            //Item concreteItemOfFactoryA = lootPoolGenerator.FactoryMethodA();
            //concreteItemOfFactoryA.PrintItem();
            //Item concreteItemOfFactoryB = lootPoolGenerator.FactoryMethodB();
            //concreteItemOfFactoryB.PrintItem();
            #endregion
            #region Prototype
            //Console.WriteLine();
            ////create new color
            //Color newColor = new Color(new IDInfo(123), "new color", 244, 255, 0, 0);
            //Color shallowCopy = (Color)newColor.CloneShallowCopy("shallow copy");
            //Color deepCopy = (Color)newColor.CloneDeepCopy("deep copy");

            ////Display instance and both clones
            //newColor.PrintColor();
            //shallowCopy.PrintColor();
            //deepCopy.PrintColor();

            ////change a normal value
            //newColor._red = 100;

            ////change a referenced value
            //newColor.IDInfo._ID = 1000;

            ////Display changes
            //Console.WriteLine("\nNew instance with new values:\n");
            //newColor.PrintColor();
            //Console.WriteLine("shallow copy changed only the reference values (ID), NOT the changed color (red)");
            //shallowCopy.PrintColor();
            //Console.WriteLine("deep copy kept all changes");
            //deepCopy.PrintColor();
            #endregion
            #region FlyWeight
            //CarStore carStore = new CarStore();
            #endregion
            #region Iterator
            //Console.WriteLine();

            ////Create new aggregate
            //Console.WriteLine("Creating Aggregate");
            //Aggregate aggregate = new Aggregate();

            ////Add items to the aggregates collection / list
            //Console.WriteLine("Filling Aggregate's List:");
            //aggregate[0] = "Item A";
            //aggregate[1] = "Item B";
            //aggregate[2] = "Item C";
            //aggregate[3] = "Item D";

            ////Create Iterator and provide the aggregate
            //Iterator iter = aggregate.CreateIterator();
            //Console.WriteLine("Iterating over Aggregate:");
            //object item = iter.First();
            //while (item != null) 
            //{
            //    Console.WriteLine(item);
            //    item = iter.Next();
            //}
            #endregion
            #region Observer
            //Console.WriteLine();

            ////Creating subjects
            //ConcreteSubject concreteSubject1 = new ConcreteSubject("(Concrete Subject 1)");
            //ConcreteSubject concreteSubject2 = new ConcreteSubject("(Concrete Subject 2)");
            //Console.WriteLine($"Created {ConcreteSubject._instancesCount} subjects: {concreteSubject1._name} | {concreteSubject2._name}\n");

            ////Creating observers
            //Observer observer1 = new Observer(concreteSubject1, $"[Observer 1, observing {concreteSubject1._name}]");
            //Observer observer2 = new Observer(concreteSubject1, $"[Observer 2, observing {concreteSubject1._name}]");
            //Observer observer3 = new Observer(concreteSubject2, $"[Observer 3, observing {concreteSubject2._name}]");
            //Console.WriteLine($"Created {Observer._instancesCount} observers: {observer1._name} | {observer2._name} | {observer3._name}\n");

            ////Subscribe the subjects to the observers
            //concreteSubject1.Subscribe(observer1);
            //concreteSubject1.Subscribe(observer2);
            //concreteSubject2.Subscribe(observer3);
            //Console.WriteLine();

            ////Set the state of one subject
            //concreteSubject1.SubjectState = "State 1";
            //Console.WriteLine($"Setting subject state of {concreteSubject1._name} to: [{concreteSubject1.SubjectState}]");
            //Console.WriteLine();

            ////Notify all observing objects (observer1 and 2) of the changes
            //concreteSubject1.Notify();
            ////As you can see, the notified observers(1 and 2) are setting their states accordingly
            #endregion
            #region Command
            //Console.WriteLine();

            ////Creating receiver, invoker and command
            //Receiver receiver = new Receiver();
            //Command command = new ConcreteCommand(receiver);
            //Invoker invoker = new Invoker();

            ////Set command
            //invoker.SetCommand(command);

            ////Execute command
            //invoker.ExecuteCommand();

            #endregion
            Console.ReadLine();
        }

    }
}