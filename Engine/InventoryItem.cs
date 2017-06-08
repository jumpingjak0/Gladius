using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class InventoryItem
    {
        public int Quantity;
        public Item Item;

        public InventoryItem(Item item)
        {
            Item = item;
            Quantity = 1;
        }

        public override string ToString()
        {
            return this.Item.Name;
        }

    }
}
