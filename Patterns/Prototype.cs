using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO:nochma drüberschaun
/// <summary>
/// Copys and instantiates prototypes
/// Differentiate between 'deep' and 'shallow' copies
/// Deep copies duplicate ALL types / Shallow copies copy only reference values (here: ID)
/// Example: Unity Prefabs, Colormanaging
/// Link: https://www.dofactory.com/net/prototype-design-pattern
///       https://refactoring.guru/design-patterns/prototype/csharp/example
/// </summary>

namespace SoftwareDesignPatterns.Patterns
{
    public abstract class ColorPrototype
    {
        public IDInfo IDInfo;
        public string _name;
        public byte _red;
        public byte _green;
        public byte _blue;
        public byte _alpha;

        public ColorPrototype(IDInfo id, string name, byte red, byte green, byte blue, byte alpha)
        {
            IDInfo = id;
            _name = name;
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = alpha;
        }

        public abstract ColorPrototype CloneShallowCopy(string copyName);
        public abstract ColorPrototype CloneDeepCopy(string copyName);
        public abstract void PrintColor();
    }

    public class Color : ColorPrototype
    {
        public Color(IDInfo id, string name, byte red, byte green, byte blue, byte alpha) : base(id, name, red, green, blue, alpha)
        {
        }

        // returns shallow copy / only instantiates new instance
        public override ColorPrototype CloneShallowCopy(string copyName)
        {
            ColorPrototype colorPrototype = (ColorPrototype)this.MemberwiseClone();
            colorPrototype._name = copyName;
            return colorPrototype;
        }

        //returns deep copy / clones entire object
        public override ColorPrototype CloneDeepCopy(string copyName)
        {
           ColorPrototype colorPrototype = (ColorPrototype)this.MemberwiseClone();
            colorPrototype._name = copyName;
            colorPrototype.IDInfo = new IDInfo(IDInfo._ID);
            colorPrototype._red = _red;
            colorPrototype._green = _green;
            colorPrototype._blue = _blue;
            colorPrototype._alpha = _alpha;
            return colorPrototype;
        }

        /// <summary>
        /// Debug for console
        /// </summary>
        public override void PrintColor()
        {
            Console.WriteLine($"[{this._name}] with ID [{this.IDInfo._ID}] and values RGBA: [{_red}|{_green}|{_blue}|{_alpha}]");
        }
    }

    public class IDInfo
    {
        public int _ID;
        public IDInfo(int idNR)
        {
            _ID = idNR;
        }
    }

}
