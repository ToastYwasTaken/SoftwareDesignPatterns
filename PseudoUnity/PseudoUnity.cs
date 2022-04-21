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
            Console.WriteLine($"Triggered DontDestroyOnLoad({obj})");
        }
        public static void Destroy(object obj)
        {
            Console.WriteLine($"Triggered Destroy({obj})");
        }
    }
    public class Component
    {

    }
    public class GameObject
    {
        public int transformPosition;
        public GameObject(string name)
        {

        }
        public void AddCapsuleCollider()
        {
            Console.WriteLine("Added capsule collider");
        }
    }
}
