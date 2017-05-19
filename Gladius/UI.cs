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
        
        

        public UI()
        {
            InitializeComponent();
            panelTravel.Visible = false;
            World.createTestTownProctoria();           
            Player.CurrentTown = World.TownByID(World.TOWN_ID_PROCTORIA);
            rtbTownDescription.Text = Player.CurrentTown.UpdateTownDescription();

            

        }

        private void btnTravel_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelTravel.Visible = true;
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
            BattlefieldForm bf = new BattlefieldForm();
            bf.Show();
        }
    }
}
