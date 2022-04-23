using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns
{
    /// <summary>
    /// Only one instance of the class is allowed
    /// to avoid errors due to multiple accessors 
    /// This version is not threadsafe
    /// Example: GameManager, SoundManager
    /// Link: https://www.dofactory.com/net/singleton-design-pattern
    /// </summary>

    public class Singleton
    {
        private static Singleton _Instance;
        public Singleton() { }

        public static Singleton GetInstance()
        {
            if (_Instance == null)
            {
                Console.WriteLine("Instance was null -> creating new Singleton");
                _Instance = new Singleton();
            }
            Console.WriteLine("Instance already exists -> keeping original");
            return _Instance;
        }
    }
}
