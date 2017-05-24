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
    public partial class UI : Form
    {
        public bool MyGladList;
        public UI()
        {
            InitializeComponent();           
            panelTravel.Visible = false;
            panelList.Visible = false;
            World.Create();           
            Player.CurrentTown = World.TownByID(World.TOWN_ID_PROCTORIA);
            rtbTownDescription.Text = Player.CurrentTown.UpdateTownDescription();
            
            
        }

        private void btnTravel_Click(object sender, EventArgs e)
        {            
            panelTravel.Visible = true;
            panelList.Visible = false;
        }
        private void btnProctoria_Click(object sender, EventArgs e)
        {
            Player.CurrentTown = World.TownByID(World.TOWN_ID_PROCTORIA);
            rtbTownDescription.Text = Player.CurrentTown.UpdateTownDescription();
            panelTravel.Visible = false;
            panelMenu.Visible = true;
        }
        private void btnCthakMij_Click(object sender, EventArgs e)
        {
            Player.CurrentTown = World.TownByID(World.TOWN_ID_CTHAKMIJ);
            rtbTownDescription.Text = Player.CurrentTown.UpdateTownDescription();
            panelTravel.Visible = false;
            panelMenu.Visible = true;
        }
        private void btnEllaneraan_Click(object sender, EventArgs e)
        {
            Player.CurrentTown = World.TownByID(World.TOWN_ID_ELLANERAAN);
            rtbTownDescription.Text = Player.CurrentTown.UpdateTownDescription();
            panelTravel.Visible = false;
            panelMenu.Visible = true;
        }
        private void btnAttelair_Click(object sender, EventArgs e)
        {
            Player.CurrentTown = World.TownByID(World.TOWN_ID_ATTELAIR);
            rtbTownDescription.Text = Player.CurrentTown.UpdateTownDescription();
            panelTravel.Visible = false;
            panelMenu.Visible = true;
        }

        private void btnArena_Click(object sender, EventArgs e)
        {
            BattlefieldForm bf = new BattlefieldForm(this, Player.MySchool, World.GladiatorList);
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
            buttonPuchase.Visible = false;
            labelGold.Visible = false;
            dgvMyGladiators.RowHeadersVisible = false;
            dgvMyGladiators.ColumnCount = 1;
            dgvMyGladiators.Rows.Clear();
            if (Player.MySchool != null)
            {
                foreach (Gladiator gladiator in Player.MySchool)
                {
                    dgvMyGladiators.Rows.Add(gladiator.Name);
                }
            }
            dgvMyGladiators.Width = 100;
            dgvMyGladiators.Columns[0].Width = 97;
            
        }

        private void btnViewGladiator_Click(object sender, EventArgs e)
        {
            string gladName = (string)dgvMyGladiators.CurrentCell.Value;
            GladiatorView gv = new GladiatorView(Gladiator.PickGladitorFromDGV(MyGladList, gladName), MyGladList);
            gv.Show();
            
        }

        private void btnGladShop_Click(object sender, EventArgs e)
        {
            MyGladList = false;
            panelList.Visible = true;
            panelTravel.Visible = false;
            buttonPuchase.Visible = true;
            labelGold.Visible = true;
            labelGold.Text = "Gold: " + Player.Gold.ToString();
            dgvMyGladiators.RowHeadersVisible = false;
            dgvMyGladiators.ColumnCount = 2;
            dgvMyGladiators.Columns[0].Name = "Name";
            dgvMyGladiators.Columns[1].Name = "Price";
            dgvMyGladiators.Rows.Clear();
            foreach (Gladiator gladiator in World.TempGladList ) 
            {
                dgvMyGladiators.Rows.Add(gladiator.Name, gladiator.Value);
            }
            dgvMyGladiators.Width = 150;
            dgvMyGladiators.Columns[0].Width = 97;
            dgvMyGladiators.Columns[1].Width = 47;
        }

        private void buttonPuchase_Click(object sender, EventArgs e)
        {

            try
            {
                World.GladiatorShopByID(World.GLADIATOR_SHOP_ID_PROCTORIA).PurchaseGladiator(Gladiator.PickGladitorFromDGV(MyGladList, (string)dgvMyGladiators.CurrentCell.Value));
                dgvMyGladiators.Rows.Clear();
                foreach (Gladiator gladiator in World.TempGladList)
                {
                    dgvMyGladiators.Rows.Add(gladiator.Name, gladiator.Value);
                }
            }
            catch
            {
                return;
            }
        }
    }
}
