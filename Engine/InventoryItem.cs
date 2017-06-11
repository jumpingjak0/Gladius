using System;
using System.Collections.Generic;
using System.IO;
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

        public InventoryItem(Item item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }


        public override string ToString()
        {
            return this.Item.Name;
        }

        internal void SaveInventoryItem(StreamWriter writer)
        {
            string saveInformation = Item.ItemType + "|" + Item.ID + "|" + Quantity;
            writer.WriteLine(saveInformation);
        }
    }
}
