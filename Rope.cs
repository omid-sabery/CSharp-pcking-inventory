using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Rope : InventoryItem
    {
        public Rope() : base(1f, 1.5f) { }
        public override string ToString()
        {
            return "Rope";
        }
    }
}
