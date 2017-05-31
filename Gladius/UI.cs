﻿using System;
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
    public partial class UI : Form
    {
        public bool MyGladList;
        public UI()
        {
            InitializeComponent();           
            panelTravel.Visible = false;
            panelList.Visible = false;
            panelTournamentSelector.Visible = false;
            World.Create();
            Player.CurrentTown = World.TownByID(World.TOWN_ID_PROCTORIA);
            rtbUI.Text = Player.CurrentTown.UpdateTownDescription();
        }

        public string shopType = "";

        private void btnTravel_Click(object sender, EventArgs e)
        {            
            panelTravel.Visible = true;
            panelList.Visible = false;
            panelTournamentSelector.Visible = false;

        }
        private void btnProctoria_Click(object sender, EventArgs e)
        {
            Player.CurrentTown = World.TownByID(World.TOWN_ID_PROCTORIA);
            rtbUI.Text = Player.CurrentTown.UpdateTownDescription();
            panelTravel.Visible = false;
            panelMenu.Visible = true;
        }
        private void btnCthakMij_Click(object sender, EventArgs e)
        {
            Player.CurrentTown = World.TownByID(World.TOWN_ID_CTHAKMIJ);
            rtbUI.Text = Player.CurrentTown.UpdateTownDescription();
            panelTravel.Visible = false;
            panelMenu.Visible = true;
        }
        private void btnEllaneraan_Click(object sender, EventArgs e)
        {
            Player.CurrentTown = World.TownByID(World.TOWN_ID_ELLANERAAN);
            rtbUI.Text = Player.CurrentTown.UpdateTownDescription();
            panelTravel.Visible = false;
            panelMenu.Visible = true;
        }
        private void btnAttelair_Click(object sender, EventArgs e)
        {
            Player.CurrentTown = World.TownByID(World.TOWN_ID_ATTELAIR);
            rtbUI.Text = Player.CurrentTown.UpdateTownDescription();
            panelTravel.Visible = false;
            panelMenu.Visible = true;
        }

        private void btnArena_Click(object sender, EventArgs e)
        {
           
           
                panelList.Visible = false;
                panelTravel.Visible = false;
                panelTournamentSelector.Visible = true;
                cbTournament.DataSource = Player.CurrentTown.Arena.Tournaments;
                cbTournament.DisplayMember = "Name";
                cbTournament.ValueMember = "ID";
                cbTournament.SelectedIndex = 0;
            
        }

        private void btnEnterTournament_Click(object sender, EventArgs e)
        {
            Tournament currentTournament = (Tournament)cbTournament.SelectedItem;
            Player.CurrentTournament = currentTournament;
            BattlefieldForm bf = new BattlefieldForm(this, Player.MySchool, currentTournament.EnemyTeam);
            bf.Show();
            panelMenu.Visible = false;
            panelTravel.Visible = false;
            panelList.Visible = false;
        }

        public void MenuVisibilty(bool visibility)
        {
            panelMenu.Visible = visibility;
        }

        private void btnMyGlad_Click(object sender, EventArgs e)
        {
            MyGladList = true;
            panelList.Visible = true;
            panelTravel.Visible = false;
            buttonPurchase.Visible = false;
            labelGold.Visible = false;
            dgvUI.RowHeadersVisible = false;
            dgvUI.ColumnCount = 1;
            dgvUI.Columns[0].Name = "Name";
            dgvUI.Rows.Clear();
            if (Player.MySchool != null)
            {
                foreach (Gladiator gladiator in Player.MySchool)
                {
                    dgvUI.Rows.Add(gladiator.Name);
                }
            }
            dgvUI.Width = 100;
            dgvUI.Columns[0].Width = 97;
            
        }

        private void btnViewGladiator_Click(object sender, EventArgs e)
        {
            string gladName = (string)dgvUI.CurrentCell.Value;
            GladiatorView gv = new GladiatorView(Gladiator.PickGladitorFromDGV(MyGladList, gladName), MyGladList);
            gv.Show();
            
        }

        private void btnGladShop_Click(object sender, EventArgs e)
        {
            shopType = "Gladiator";
            GladiatorShop currentShop = World.GladiatorShopByID(Player.CurrentTown.GladiatorShop.ID);
            rtbUI.Text += Environment.NewLine + currentShop.Name + Environment.NewLine
                + currentShop.Description + Environment.NewLine;
            MyGladList = false;
            panelList.Visible = true;
            panelTravel.Visible = false;
            panelTournamentSelector.Visible = false;
            buttonPurchase.Visible = true;
            labelGold.Visible = true;
            labelGold.Text = "Gold: " + Player.Gold.ToString();
            dgvUI.RowHeadersVisible = false;
            dgvUI.ColumnCount = 2;
            dgvUI.Columns[0].Name = "Name";
            dgvUI.Columns[1].Name = "Price";
            dgvUI.Rows.Clear();
            foreach (Gladiator gladiator in currentShop.Stock) 
            {
                dgvUI.Rows.Add(gladiator.Name, gladiator.Value);
            }
            dgvUI.Width = 150;
            dgvUI.Columns[0].Width = 97;
            dgvUI.Columns[1].Width = 47;
        }

        private void buttonPuchase_Click(object sender, EventArgs e)
        {
            switch (shopType)
            {
                case "Gladiator":
                    {
                        try
                        {
                            rtbUI.Text += Environment.NewLine + (World.GladiatorShopByID(World.GLADIATOR_SHOP_ID_PROCTORIA).PurchaseGladiator(Gladiator.PickGladitorFromDGV(MyGladList, (string)dgvUI.CurrentCell.Value))) + Environment.NewLine;
                            labelGold.Text = Player.Gold.ToString();
                            dgvUI.Rows.Clear();
                            foreach (Gladiator gladiator in World.TempGladList)
                            {
                                dgvUI.Rows.Add(gladiator.Name, gladiator.Value);
                            }
                        }
                        catch
                        {
                            return;
                        }
                        break;
                    }
                case "Item":
                    {
                        break;
                    }
            }
            
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            dgvUI.Rows.Clear();
            dgvUI.Visible = true;
            buttonPurchase.Visible = true;
            panelList.Visible = true;
            panelTravel.Visible = false;
            panelTournamentSelector.Visible = false;
            labelGold.Visible = true;
            btnViewGladiator.Visible = false;
            labelGold.Text = "Gold: " + Player.Gold.ToString();
            dgvUI.RowHeadersVisible = false;
            dgvUI.ColumnCount = 3;
            dgvUI.Columns[0].Name = "Item";
            dgvUI.Columns[1].Name = "Price";
            dgvUI.Columns[2].Name = "Quantity";
            
            foreach (InventoryItem item in Player.Inventory)
            {
                dgvUI.Rows.Add(item.Item.Name, item.Item.Value, item.Quantity);
            }
            dgvUI.Width = 150;
            dgvUI.Columns[0].Width = 97;
            dgvUI.Columns[1].Width = 47;

        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            shopType = "Item";
            dgvUI.Rows.Clear();
            ItemShop currentShop = World.ItemShopByID(Player.CurrentTown.ItemShop.ID);
            dgvUI.Visible = true;
            buttonPurchase.Visible = true;
            panelList.Visible = true;
            panelTravel.Visible = false;
            panelTournamentSelector.Visible = false;
            labelGold.Visible = true;
            btnViewGladiator.Visible = false;
            labelGold.Text = "Gold: " + Player.Gold.ToString();
            dgvUI.RowHeadersVisible = false;
            dgvUI.ColumnCount = 2;
            dgvUI.Columns[0].Name = "Item";
            dgvUI.Columns[1].Name = "Price";
            rtbUI.Text += Environment.NewLine + currentShop.Name + Environment.NewLine
                + currentShop.Description + Environment.NewLine;

            foreach (Item item in currentShop.Stock)
            {
                dgvUI.Rows.Add(item.Name, item.Value);
            }
            dgvUI.Width = 150;
            dgvUI.Columns[0].Width = 97;
            dgvUI.Columns[1].Width = 47;

        }

        private void cbTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tournament selection = (Tournament)cbTournament.SelectedItem;
            rtbUI.Text += Environment.NewLine + Environment.NewLine + selection.Name + Environment.NewLine + selection.Description;
        }

        private void rtbUI_TextChanged(object sender, EventArgs e)
        {
            rtbUI.SelectionStart = rtbUI.Text.Length;
            rtbUI.ScrollToCaret();
        }
    }
}
