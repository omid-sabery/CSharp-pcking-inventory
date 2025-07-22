using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Water : InventoryItem
    {
        public Water() : base(2f, 3f) { }
        public override string ToString()
        {
            return "Water";
        }
    }
}
