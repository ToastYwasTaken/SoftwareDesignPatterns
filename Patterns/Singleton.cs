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
    /// Example: GameManager, SoundManager
    /// </summary>
    public class Singleton 
    {
        public static Singleton Instance { get; private set; }
        
        public void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                PseudoUnity.DontDestroyOnLoad(this);
            }
            else PseudoUnity.Destroy(this);
        }

    }
}
