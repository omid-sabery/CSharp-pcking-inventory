using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class FoodRation : InventoryItem
    {
        public FoodRation() : base(1f, 0.5f) { }
        public override string ToString()
        {
            return "Food Ration";
        }
    }
}
