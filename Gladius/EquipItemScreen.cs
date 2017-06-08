using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Engine;

namespace Gladius
{
    public partial class EquipItemScreen : Form
    {
        ItemType ItemType;
        Gladiator GladiatorToEquip;
        GladiatorView GladiatorView;
        

        public EquipItemScreen(ItemType itemType, Gladiator inGlad, GladiatorView InGladiatorView)
        {
            InitializeComponent();
            this.Text = "Equip " + itemType.ToString();
            ItemType = itemType;
            GladiatorView = InGladiatorView;
            foreach(InventoryItem ii in Player.Inventory)
            {
                if(ii.Item.ItemType == itemType && ii.Quantity > 0)
                {
                    cbItemToEquip.Items.Add(ii);
                }
            }
            try
            {
                cbItemToEquip.SelectedIndex = 0;
            }
            catch
            { }
            GladiatorToEquip = inGlad;
        }

        private void btnEquipItem_Click(object sender, EventArgs e)
        {
            InventoryItem ItemToEquip = (InventoryItem)cbItemToEquip.SelectedItem;
            Item ItemToUnequip; 

            switch(ItemType)
            {
                case ItemType.Armour:
                    {
                        UnequipItem(GladiatorToEquip.ArmourEquipped);
                        GladiatorToEquip.ArmourEquipped = (Armour)ItemToEquip.Item;
                        ItemToEquip.Quantity--;
                        break;
                    }
                case ItemType.Weapon:
                    {
                        UnequipItem(GladiatorToEquip.WeaponEquipped);
                        GladiatorToEquip.WeaponEquipped = (Weapon)ItemToEquip.Item;
                        ItemToEquip.Quantity--;
                        break;
                    }
            }
            GladiatorView.UpdateGladiator();
            this.Close();
        }

        private void UnequipItem(Item ItemToUnequip)
        {           
            if (Player.HasThisItemInInventory(ItemToUnequip.Name))
            {
                World.InventoryItemByName(ItemToUnequip.Name).Quantity += 1;
            }
            else
            {
                Player.Inventory.Add(new InventoryItem(ItemToUnequip));
            }
        }
    }
}
