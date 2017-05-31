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
        static BattleTile[,] ArenaField;
        public static BattleTile SelectedTile;

        public BattlefieldForm(UI form1, List<Gladiator> myTeam, List<Gladiator> enemyTeam)
        {          
            InitializeComponent();
            formUI = form1; 
            lblTitle.Text = Player.CurrentTown.Name + " Arena";
            btnEndBattle.Visible = false;
            MyTeam = myTeam;
            EnemyTeam = enemyTeam;
            Populate();
            AddGladiatorsToArenaField(MyTeam, EnemyTeam, ArenaField);
            foreach(BattleTile bt in ArenaField)
            {
                if (bt != null)
                {
                    bt.ShowTileIsOccupied();
                }
            }
            
            
        }

        public void Populate()
        {
            
            int[,] map = World.BattlefieldByID(Player.CurrentTown.ID).Field;
            int width = map.GetLength(0);
            int height = map.GetLength(1);
            BattlefieldForm.ArenaField = new BattleTile[width + 1, height + 1];
            BattleTile[,] arenaField = new BattleTile[width, height];
            int panelWidth = panel1.Width / width;
            int panelHeight = panel1.Height / height;
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Occupied occ;                   
                    occ = Occupied.Empty;                  
                    BattleTile square = new BattleTile(panel1, occ, panelHeight, panelWidth, j, i, map[j,i], rtbBattle, SelectedTile, MyTeam, EnemyTeam, ArenaField, height);
                    panel1.Controls.Add(square.Button);
                    arenaField[j,i] = square;                   
                }
            }

            
            BattleTile[,] arenafieldTemp = new BattleTile[width + 1, height + 1];
            BattleTile.endBattle = btnEndBattle;

            foreach(BattleTile bt in arenaField)
            {
                arenafieldTemp[bt.X, bt.Y] = bt;
            }
            BattlefieldForm.ArenaField = arenafieldTemp;
            BattleTile.ArenaField = ArenaField;
        }

        private void AddGladiatorsToArenaField(List<Gladiator> myTeam, List<Gladiator> enemyTeam, BattleTile[,] field)
        {
            int i = 0;
            if (myTeam != null)
            {
                foreach (Gladiator glad in myTeam)
                {
                    i++;
                    field[1, i].gladiator = glad;
                    glad.State = State.alive;
                    glad.CurrentHP = glad.MaxHP;
                    glad.CurrentTile = field[1, i];
                    glad.X = field[1, i].X;
                    glad.Y = field[1, i].Y;
                    glad.potentialEXP = glad.EXP;
                    glad.HasMoved = false;
                }
            }
            i = 0;
            if (enemyTeam != null)
            {
                foreach (Gladiator glad in enemyTeam)
                {
                    i++;
                    field[(field.GetLength(0) - 1), i].gladiator = glad;
                    glad.CurrentHP = glad.MaxHP;
                    glad.State = State.alive;
                    glad.CurrentTile = field[(field.GetLength(0) - 1), i];
                    glad.Y = field[(field.GetLength(0) - 1), i].Y;
                    glad.X = field[(field.GetLength(0) - 1), i].X;
                    glad.HasMoved = false;
                    
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

        private void rtbBattle_TextChanged(object sender, EventArgs e)
        {
            rtbBattle.SelectionStart = rtbBattle.Text.Length;
            rtbBattle.ScrollToCaret();
        }

        private void btnEndBattle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
