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
    public partial class BattlefieldForm : Form
    {
        
        public BattlefieldForm()
        {
            InitializeComponent();
            Populate();


        }

        public void Populate()
        {
            int[,] map = World.BattlefieldByID(Player.CurrentTown.ID).Field;
            int height = map.GetLength(0);
            int width = map.GetLength(1);
            int panelWidth = panel1.Width / width;
            int panelHeight = panel1.Height / height;
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Occupied occ;                   
                    occ = Occupied.Empty;                  
                    BattleTile square = new BattleTile(panel1, occ, panelHeight, panelWidth, i, j, map[i,j]);
                    panel1.Controls.Add(square.Button);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
