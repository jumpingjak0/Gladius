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
    public enum Occupied
    {
        Occupied,
        Empty
    }

    public class BattleTile
    {
        public Button Button;
        public Gladiator gladiator;
        int Height;
        int Width;
        int TopLoc;
        int LeftLoc;
        public int X;
        public int Y;
        RichTextBox BattleMonitor;
        static BattleTile SelectedTile;
        

        public BattleTile(Panel panelIn, Occupied state, int height, int width, int x, int y, int mapSquare, RichTextBox bm, BattleTile selectedTile)
        {
            Button = new Button();
            gladiator = null;
            Height = height;
            Width = width;
            TopLoc = height * x;
            LeftLoc = width * y;
            X = x;
            Y = y;
            BattleMonitor = bm;
            SelectedTile = selectedTile;
            Button.Click += new EventHandler(buttonClicked);

            switch (mapSquare)
            {
                case 0:
                    {
                        Button.BackColor = Color.Aqua;
                        break;
                    }
                case 1:
                    {
                        Button.BackColor = Color.Aquamarine;
                        break;
                    }
            }
            Button.Height = Height;
            Button.Width = Width;
            Button.Left = LeftLoc;
            Button.Top = TopLoc;
            

                   
        }

        public void ShowTileIsOccupied()
        {
            Button.Font = new Font(Button.Font.FontFamily, 20);
            

            if (this.gladiator != null)
            {
                if (gladiator.InTeam)
                {
                    Button.ForeColor = Color.Green;
                }
                else
                {
                    Button.ForeColor = Color.Red;
                }
                Button.Text = this.gladiator.Name;
            }
            else
            {
                Button.Text = "";

            }
        }

        public void buttonClicked(object sender, EventArgs e)
        {
            if(BattleMethods.SelectedGladiator == null)
            {
                if(this.gladiator != null)
                {
                    BattleMethods.SelectedGladiator = this.gladiator;
                    BattleMonitor.Text = BattleMethods.SelectedGladiator.Name + " selected." + Environment.NewLine;
                    SelectedTile = this;                  
                }
            }
            else
            {
                if (this.gladiator == null)
                {
                    this.gladiator = BattleMethods.SelectedGladiator;
                    BattleMethods.SelectedGladiator = null;
                    SelectedTile.gladiator = null;
                    SelectedTile.Button.Text = "";
                    SelectedTile = null;
                    ShowTileIsOccupied();
                    BattleMonitor.Clear();

                }
                else if (this == SelectedTile)
                {
                    BattleMonitor.Text += Environment.NewLine + "You are already here.";
                }


                else
                {
                    BattleMonitor.Text += Environment.NewLine + "You cannot move here as this tile is occupied.";
                }
            }

        }

    }
}
