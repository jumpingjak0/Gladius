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
        Player player = new Player("Jack");
        

        public UI()
        {
            InitializeComponent();
            panelTravel.Visible = false;
            World.createTestTownProctoria();           
            player.CurrentTown = World.TownByID(World.TOWN_ID_PROCTORIA);
            rtbTownDescription.Text = player.CurrentTown.UpdateTownDescription();

            panelTravel.

        }

        private void btnTravel_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelTravel.Visible = true;
        }
        private void btnProctoria_Click(object sender, EventArgs e)
        {
            player.CurrentTown = World.TownByID(World.TOWN_ID_PROCTORIA);
            rtbTownDescription.Text = player.CurrentTown.UpdateTownDescription();
            panelTravel.Visible = false;
            panelMenu.Visible = true;
        }
        private void btnCthakMij_Click(object sender, EventArgs e)
        {
            player.CurrentTown = World.TownByID(World.TOWN_ID_CTHAKMIJ);
            rtbTownDescription.Text = player.CurrentTown.UpdateTownDescription();
            panelTravel.Visible = false;
            panelMenu.Visible = true;
        }
        private void btnEllaneraan_Click(object sender, EventArgs e)
        {
            player.CurrentTown = World.TownByID(World.TOWN_ID_ELLANERAAN);
            rtbTownDescription.Text = player.CurrentTown.UpdateTownDescription();
            panelTravel.Visible = false;
            panelMenu.Visible = true;
        }
        private void btnAttelair_Click(object sender, EventArgs e)
        {
            player.CurrentTown = World.TownByID(World.TOWN_ID_ATTELAIR);
            rtbTownDescription.Text = player.CurrentTown.UpdateTownDescription();
            panelTravel.Visible = false;
            panelMenu.Visible = true;
        }
    }
}
