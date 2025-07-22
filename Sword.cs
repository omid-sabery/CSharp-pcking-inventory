using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Sword : InventoryItem
    {
        public Sword() : base(5f, 3f) { }
        public override string ToString()
        {
            return "Sword";
        }
    }
}
