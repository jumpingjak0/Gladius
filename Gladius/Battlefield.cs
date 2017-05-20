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
        private readonly UI formUI;
        List<Gladiator> MyTeam;
        List<Gladiator> EnemyTeam;
        BattleTile[,] ArenaField;
        public static BattleTile SelectedTile;

        public BattlefieldForm(UI form1, List<Gladiator> myTeam, List<Gladiator> enemyTeam)
        {
            InitializeComponent();
            formUI = form1; 
            lblTitle.Text = Player.CurrentTown.Name + " Arena";           
            Populate();
            MyTeam = myTeam;
            EnemyTeam = enemyTeam;
            AddGladiatorsToArenaField(MyTeam, EnemyTeam, ArenaField);
            foreach(BattleTile bt in ArenaField)
            {
                bt.ShowTileIsOccupied();
            }
            
            
        }

        public void Populate()
        {
            int[,] map = World.BattlefieldByID(Player.CurrentTown.ID).Field;
            int height = map.GetLength(0);
            int width = map.GetLength(1);
            BattleTile[,] arenaField = new BattleTile[height, width];
            int panelWidth = panel1.Width / width;
            int panelHeight = panel1.Height / height;
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Occupied occ;                   
                    occ = Occupied.Empty;                  
                    BattleTile square = new BattleTile(panel1, occ, panelHeight, panelWidth, i, j, map[i,j], rtbBattle, SelectedTile);
                    panel1.Controls.Add(square.Button);
                    arenaField[i,j] = square;                   
                }
            }
            ArenaField = arenaField;            
        }

        private void AddGladiatorsToArenaField(List<Gladiator> myTeam, List<Gladiator> enemyTeam, BattleTile[,] field)
        {
            int i = 0;
            if (myTeam != null)
            {
                foreach (Gladiator glad in myTeam)
                {
                    i++;
                    field[0, i].gladiator = glad;
                    glad.XLoc = field[0, i].X;
                    glad.YLoc = field[0, i].Y;

                }
            }
            i = 0;
            if (enemyTeam != null)
            {
                foreach (Gladiator glad in enemyTeam)
                {
                    i++;
                    field[(field.GetLength(1) - 1), i].gladiator = glad;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
           
        private void BattlefieldForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formUI.MenuVisibilty(true);
        }
    
    }
}
