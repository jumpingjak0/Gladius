using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class ItemShop : Shop
    {
        public List<Item> Stock;

        public ItemShop(int id, string name, string vendorName, string description, List<Item> stock): base(id, name, description, vendorName)
        {
            
            Stock = stock;
        }
    }
}
