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
    public partial class GladiatorView : Form
    {
        Gladiator inGladiator;
        public GladiatorView(Gladiator gladIn, bool myGladList)
        {
            InitializeComponent();
            inGladiator = gladIn;
            this.Text = inGladiator.Name;
            labelName.Text = inGladiator.Name;

            if(myGladList)
            {
                panelMyGladControls.Visible = true;
            }
            else
            {
                panelMyGladControls.Visible = false;
            }
            if (inGladiator.Nickname == null)
            {
                labelNickname.Text = "";
            }
            else
            {
                labelNickname.Text = inGladiator.Nickname;
            }
            labelLevel.Text = inGladiator.Level.ToString();
            labelExpToNextLevel.Text = inGladiator.ExpToNextLevel.ToString();
            labelHealth.Text = inGladiator.MaxHP.ToString();
            labelAttack.Text = inGladiator.AttackDamage.ToString();
            labelWeapon.Text = inGladiator.WeaponEquipped.ToString();
            labelArmour.Text = inGladiator.ArmourEquipped.ToString();
            labelDescription.Text = inGladiator.Description;           
        }

        private void buttonNickname_Click(object sender, EventArgs e)
        {
            inGladiator.SetGladiatorNickname(textBoxNickname.Text);
            labelNickname.Text = inGladiator.Nickname;
            textBoxNickname.Clear();
        }

       
    }
}
