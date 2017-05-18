using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Shop
    {
        public int ID;
        public string Name;
        public string Description;
        public string VendorName;

        public Shop(int id, string name, string description, string vendorName)
        {
            ID = id;
            Name = name;
            Description = description;
            VendorName = vendorName;
        }

    }
}
