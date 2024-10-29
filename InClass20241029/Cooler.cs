using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass20241029
{
    /// <summary>
    /// This class models the cooler found in our classroom
    /// </summary>
    internal class Cooler
    {
        private String _color;  // Properties by default are private. Private properties are prefixed with an _ by convention.
        public string Color
        { // Provide access to the private property. Always add getter and setter for private properties. Getter and Setter are public.
            get { return _color; }
            set
            {
                if (value.Length > 0) // Color cannot be null 
                {
                    _color = value;
                }
            }
        }

        private int _cost;
        public int Cost
        {
            get { return _cost; }
            set
            {
                if (value >= 0) // The cost cannot be negative
                {
                    _cost = value;
                }
            }
        
        }
    }
}
