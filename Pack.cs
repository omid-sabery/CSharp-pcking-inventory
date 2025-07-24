using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Pack
    {
        // Fileds
        private int _itemCount = 0;
        private float _maxWeight;
        private float _maxVolume;
        private float _currentWeight = 0;
        private float _currentVolume = 0;

        // Properties
        public InventoryItem[] Items { get; init; }
        public int Capacity { get; }
        public float MaxWeight => _maxWeight;
        public float MaxVolume => _maxVolume;
        public float CurrentWeight => _currentWeight;
        public float CurrentVolume => _currentVolume;
        public int ItemCount => _itemCount;

        // Constructor
        public Pack(int numberOfItems, float maxWeight, float maxVolume)
        {
            Items = new InventoryItem[numberOfItems];
            Capacity = numberOfItems;
            _maxWeight = maxWeight;
            _maxVolume = maxVolume;
        }

        // Methods
        public bool Add(InventoryItem item)
        {
            if (_itemCount >= Capacity)
                return false;
            if (item.Weight > _maxWeight - _currentWeight)
                return false;
            if (item.Volume > MaxVolume - _currentVolume)
                return false;
            Items[_itemCount++] = item;
            _currentWeight += item.Weight;
            _currentVolume += item.Volume;
            return true;
        }
        public override string ToString()
        {
            string packString = "Pack containing ";
            foreach (var item in Items)
            {
                if (item != null)
                  packString += item.ToString() + " ";
            }
            return  packString;
        }
    }
}
