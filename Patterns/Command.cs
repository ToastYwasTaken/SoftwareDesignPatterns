using System;

/// <summary>
/// Encapsulates a operation as object to 
/// parameterize clients with different requests
/// Example: WPF (Undo/Redo, Open, Save, ...), Networks
/// Link: https://www.dofactory.com/net/command-design-pattern
/// </summary>

namespace SoftwareDesignPatterns.Patterns
{
    /// <summary>
    /// declares interface for executing an command
    /// </summary>
    public abstract class Command
    {
        protected Receiver _receiver;
        public Command(Receiver receiver)
        {
            _receiver = receiver;
        }
        public abstract void Execute();
    }
    /// <summary>
    /// defines binding between Receiver object and Action
    /// implements Execute -> invokes corresponding 
    /// operation(s) on Receiver
    /// </summary>
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Executing...");
            _receiver.Action();
        }
    }
    /// <summary>
    /// Sets the command and passes the request
    /// </summary>
    public class Invoker
    {
        Command _command;

        public void SetCommand(Command command)
        {
            Console.WriteLine("Setting command...");
            _command = command;
        }

        public void ExecuteCommand()
        {
            Console.WriteLine("Executing command...");
            _command.Execute();
        }
    }
    /// <summary>
    /// receives the command to perform
    /// </summary>
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }
}
