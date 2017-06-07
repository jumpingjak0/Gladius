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

        public static bool ItemPurchaseSuccessful(Item item)
        {
            if (item.Value <= Player.Gold)
            {
                if (World.PlayerHasThisItemInInventory(item.Name))
                {
                    World.InventoryItemByName(item.Name).Quantity += 1;
                    Player.Gold -= item.Value;
                }
                else
                {
                    Player.Inventory.Add(new InventoryItem(new Item(item.ID, item.Value, item.Name, item.Description)));
                    Player.Gold -= item.Value;

                }
                return true;
            }
            return false;
        }
    }
}
