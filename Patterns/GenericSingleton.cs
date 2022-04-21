using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Only one instance of the generic class is allowed
/// to avoid errors due to multiple accessors 
/// Example: GameManager, SoundManager
/// Link: https://www.dofactory.com/net/singleton-design-pattern
/// </summary>

namespace SoftwareDesignPatterns
{
    public class GenericSingleton<T> where T : Component
    {
        public static T Instance { get; private set; }

        public virtual void Awake()
        {
            if (Instance == null)
            {
                Instance = this as T;
                PseudoUnity.DontDestroyOnLoad(this);
            }
            else PseudoUnity.Destroy(this);
        }
    }
}
