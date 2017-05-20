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
        Occupied State;
        int Height;
        int Width;
        int TopLoc;
        int LeftLoc;
        

        public BattleTile(Panel panelIn, Occupied state, int height, int width, int i, int j, int mapSquare)
        {
            Button = new Button();
            State = state;
            Height = height;
            Width = width;
            TopLoc = height * i;
            LeftLoc = width * j;

            switch (mapSquare)
            {
                case 0:
                    {
                        Button.BackColor = Color.Green;
                        break;
                    }
                case 1:
                    {
                        Button.BackColor = Color.Red;
                        break;
                    }
            }
            Button.Height = Height;
            Button.Width = Width;
            Button.Left = LeftLoc;
            Button.Top = TopLoc;
            

            if(state == Occupied.Occupied)
            {
                Button.Text = "G";
            }
            else
            {
                Button.Text = "";

            }

            
        
            
        }

        

    }
}
