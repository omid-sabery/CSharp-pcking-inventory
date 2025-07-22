using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class InventoryItem
    {
        public float Weight { get; init; }
        public float Volume { get; init; }

        public InventoryItem(float weight, float volume) =>
            (Weight, Volume) = (weight, volume);
    }
}
