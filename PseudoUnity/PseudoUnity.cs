using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// simmulates Unity, if implementing in Unity, 
/// simply remove PseudoUnity. before methods
/// </summary>

namespace SoftwareDesignPatterns
{
    public static class PseudoUnity
    {
        public static void DontDestroyOnLoad(object obj)
        {
            throw new NotImplementedException();
        }
        public static void Destroy(object obj)
        {
            throw new NotImplementedException();
        }
    }
    public class Component
    {

    }
}
