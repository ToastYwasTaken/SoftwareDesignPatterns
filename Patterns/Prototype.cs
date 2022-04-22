using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO:nochma drüberschaun
/// <summary>
/// Copys and instantiates prototypes
/// Differentiate between 'deep' and 'shallow' copies
/// Deep copies duplicate all types / Shallow copies copy the prototype object
/// Example: Unity Prefabs, Colormanaging
/// Link: https://www.dofactory.com/net/prototype-design-pattern
/// </summary>

namespace SoftwareDesignPatterns.Patterns
{
    public abstract class ColorPrototype
    {
        public byte _red;
        public byte _green;
        public byte _blue;
        public byte _alpha;

        public ColorPrototype(byte red, byte green, byte blue, byte alpha)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = alpha;
        }

        public abstract ColorPrototype CloneShallowCopy();
        public abstract ColorPrototype CloneDeepCopy();
    }

    public class Color : ColorPrototype
    {
        public Color(byte red, byte green, byte blue, byte alpha) : base(red, green, blue, alpha)
        {
        }

        // returns shallow copy / only instantiates new instance
        public override ColorPrototype CloneShallowCopy()
        {
            return (ColorPrototype)this.MemberwiseClone();
        }

        //returns deep copy / clones entire object
        public override ColorPrototype CloneDeepCopy()
        {
           ColorPrototype colorPrototype = (ColorPrototype)this.MemberwiseClone();
            colorPrototype._red = _red;
            colorPrototype._green = _green;
            colorPrototype._blue = _blue;
            colorPrototype._alpha = _alpha;
            return colorPrototype;
        }

    }

}
