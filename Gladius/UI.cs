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
            World.createTestTownProctoria();
            rtbTownDescription.Text = World.TownByID(World.TOWN_ID_PROCTORIA).ToString();

        }
    }
}
