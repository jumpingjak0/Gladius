using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class GladiatorShop : Shop
    {
        
        public List<Gladiator> Stock;

        public GladiatorShop(int id, string name, string vendorName, string description, List<Gladiator> stock): base(id, name, description, vendorName)
        {
            
            Stock = stock;
        }
    }
}
