using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Engine;


namespace Engine
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
        RichTextBox rtbBattleMonitor;
        public static BattleTile SelectedTile = null;
        public static List<Gladiator> MyTeam;
        public static List<Gladiator> EnemyTeam;
        public static BattleTile[,] ArenaField;
        public static Button endBattle;
        


        public BattleTile(Panel panelIn, Occupied state, int height, int width, int x, int y, int mapSquare, RichTextBox rtbbattleMonitor, BattleTile selectedTile, List<Gladiator> myTeam, List<Gladiator> enemyTeam, BattleTile[,] arena, int yHeight )
        {
            Button = new Button();
            gladiator = null;
            Height = height;
            Width = width;
            TopLoc = height * y;
            LeftLoc = width * x;
            X = x + 1;
            Y = yHeight - y;
            rtbBattleMonitor = rtbbattleMonitor;
            SelectedTile = selectedTile;
            MyTeam = myTeam;
            EnemyTeam = enemyTeam;
            ArenaField = arena;

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
            
            Button.Refresh();
            
                               
        }

        public void ShowTileIsOccupied()
        {
           Button.Font = new Font(Button.Font.FontFamily, 10);
            

            if (gladiator != null)
            {
                if (gladiator.InPlayersTeam)
                {
                    Button.ForeColor = Color.Green;
                    
                }
                else
                {
                    Button.ForeColor = Color.Red;
                }
                Button.Text = gladiator.Name;
            }
            else
            {
                Button.Text = "";
            }
            
        }

        public void buttonClicked(object sender, EventArgs e)
        {
            if(!GladiatorIsSelected())
            {
                SelectGladiator(this, rtbBattleMonitor);
            }
            else  //gladiator is already selected
            {
                if (!TileIsInMovementRange(this) && !TargetTileOccupied(this))
                {
                    rtbBattleMonitor.Text += "Cannot move here, out of range" + Environment.NewLine;
                    SelectedTile = null;
                    
                }
                else
                {  
                    if (!TargetTileOccupied(this)) //square empty so puts selected there
                    {
                        MoveGladiator(this);
                        
                        

                    }
                    else if (this == SelectedTile) //on top of self
                    {
                        rtbBattleMonitor.Text += "You are already here." + Environment.NewLine;
                        SelectedTile = null;
                       
                    }
                    else
                    {
                        if (this.gladiator.InPlayersTeam == SelectedTile.gladiator.InPlayersTeam) //can't move in to team mate
                        {
                            rtbBattleMonitor.Text += "You cannot move here as this tile is occupied." + Environment.NewLine;
                            SelectedTile = null;
                            
                        }
                        else //attack enemy
                        {
                            if (TileIsInAttackRange(this))
                            {
                                AttackGladiator(SelectedTile, this, rtbBattleMonitor);
                            }
                            else
                            {
                                rtbBattleMonitor.Text += "Out of attack range.";
                                SelectedTile = null;
                            }
                        }
                    }
                    
                }
                rtbBattleMonitor.Text += Environment.NewLine;
            }
            if(CheckTeamAllDead(EnemyTeam))
            {
                BattleWon();
            }
            if(CheckTeamAllDead(MyTeam))
            {
                BattleLost();
            }
            if(CheckAllTeamMoved(MyTeam))
            {
                foreach(Gladiator glad in EnemyTeam)
                {
                    if(glad.State == State.alive)
                    SelectedTile = glad.CurrentTile;
                    try
                    {
                        AIGladiatorTurn(FindNearestGladiatorOnPlayerTeam());
                    }
                    catch
                    {
                        return;
                    }
                }
                SelectedTile = null;
            }

        }

        public bool TargetTileOccupied(BattleTile target)
        {
            if (target.gladiator == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool GladiatorIsSelected()
        {
            if (SelectedTile == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void SelectGladiator(BattleTile clickedTile, RichTextBox rtbBattleMonitor)
        {
            if (clickedTile.gladiator != null && clickedTile.gladiator.InPlayersTeam) //no gladiator selected so selects gladiator
            {
                if (clickedTile.gladiator.HasMoved)
                {
                    rtbBattleMonitor.Text += clickedTile.gladiator.Name + " has already moved this turn." + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    SelectedTile = this;
                    rtbBattleMonitor.Text += SelectedTile.gladiator.Name + " selected." + Environment.NewLine;
                }
            }
        }
        public void MoveGladiator(BattleTile targetTile)
        {
            targetTile.gladiator = SelectedTile.gladiator;
            targetTile.gladiator.X = targetTile.X;
            targetTile.gladiator.Y = targetTile.Y;
            targetTile.gladiator.CurrentTile = targetTile;
            SelectedTile.gladiator.HasMoved = true;
            SelectedTile.gladiator = null;            
            SelectedTile.Button.Text = "";
            SelectedTile = null;
            targetTile.ShowTileIsOccupied();
        }
        public void AttackGladiator(BattleTile attacker, BattleTile defender, RichTextBox rtbBattleMonitor)
        {
            attacker.gladiator.HasMoved = true;
            rtbBattleMonitor.Text += attacker.gladiator.Name + " attacks " + defender.gladiator.Name + "." + Environment.NewLine;
            rtbBattleMonitor.Refresh();
            int damage = GladiatorDamageCalculator(attacker.gladiator, defender.gladiator);
            rtbBattleMonitor.Text += damage + " damage is dealt." + Environment.NewLine;
            rtbBattleMonitor.Refresh();
            if (defender.gladiator.CurrentHP <= 0)
            {
                rtbBattleMonitor.Text +=  defender.gladiator.Name + " has fainted." + Environment.NewLine + Environment.NewLine;
                attacker.gladiator.potentialEXP += defender.gladiator.RewardEXP;
                rtbBattleMonitor.Refresh();
                defender.gladiator.State = State.dead;
                SelectedTile = null;
                defender.gladiator = null;
                defender.ShowTileIsOccupied();
                
            }
            else
            {
                rtbBattleMonitor.Text += Environment.NewLine;
                SelectedTile = null;
            }
        }
        public bool CheckAllTeamMoved (List<Gladiator> inTeam)
        {
            bool allTeamMoved = true;
            foreach(Gladiator glad in inTeam)
            {
                if(glad.State == State.dead)
                {
                    glad.HasMoved = true;
                }
                if(glad.HasMoved == false)
                {
                    allTeamMoved = false;
                }
            }
            if(allTeamMoved)
            {
               
                foreach(Gladiator glad in inTeam)
                {
                    glad.HasMoved = false;
                }
                return true;
            }
            return false;

        }
        public bool CheckTeamAllDead (List<Gladiator> inTeam)
        {
            bool teamAllDead = true;
            foreach(Gladiator glad in inTeam)
            {
                if(glad.State == State.alive)
                {
                    teamAllDead = false;
                }
            }
            return teamAllDead;
        }
        public static int GladiatorDamageCalculator(Gladiator attacker, Gladiator defender)
        {
            int weaponDamage = RandomNumberGenerator.RandomNumber(attacker.WeaponEquipped.MinDamage, attacker.WeaponEquipped.MaxDamage);
            int damageDealt = (attacker.AttackDamage) * weaponDamage;
            int damageTaken = damageDealt / defender.ArmourEquipped.ArmourValue;
            defender.CurrentHP -= damageDealt;
            return damageTaken;
        }

        public void BattleWon()
        {
            rtbBattleMonitor.Text += "You've won the tournament!" + Environment.NewLine;
            rtbBattleMonitor.Text += "You win " + Player.CurrentTournament.RewardGold + " gold." + Environment.NewLine;
            foreach(Gladiator glad in MyTeam)
            {
                if(glad.State == State.alive)
                {
                    int expDifference = glad.potentialEXP - glad.EXP;
                    glad.EXP = glad.potentialEXP;
                    glad.EXP += Player.CurrentTournament.RewardExp;
                    rtbBattleMonitor.Text += glad.Name + " has been rewarded " + (Player.CurrentTournament.RewardExp + expDifference)  + " EXP."+ Environment.NewLine;
                    glad.LevelUpGladiator(rtbBattleMonitor);

                }
            }
            
            if(!Player.CurrentTournament.Trophy.PlayerHasTrophy)
            {
                Player.Trophies.Add(Player.CurrentTournament.Trophy);
                Player.CurrentTournament.Trophy.PlayerHasTrophy = true;
                rtbBattleMonitor.Text += "You have been awarded the " + Player.CurrentTournament.Trophy.Name + Environment.NewLine;
            }
            endBattle.Visible = true;
        }

        public void BattleLost()
        {
            rtbBattleMonitor.Text += "You've lost!";
            endBattle.Visible = true;
        }
            
        
        public bool TileIsInMovementRange(BattleTile target)
        {
            if (target.X > SelectedTile.X + SelectedTile.gladiator.movementRange || 
                    target.X < SelectedTile.X - SelectedTile.gladiator.movementRange || 
                        target.Y > SelectedTile.Y + SelectedTile.gladiator.movementRange || 
                            target.Y < SelectedTile.Y - SelectedTile.gladiator.movementRange)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool TileIsInAttackRange(BattleTile target)
        {
            if (SelectedTile.gladiator.X > target.X + target.gladiator.attackRange ||
                    SelectedTile.gladiator.X < target.X - target.gladiator.attackRange ||
                        SelectedTile.gladiator.Y > target.Y + target.gladiator.attackRange ||
                            SelectedTile.gladiator.Y < target.Y - target.gladiator.attackRange)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public BattleTile FindNearestGladiatorOnPlayerTeam()
        {
            BattleTile nearestTileWithPlayerGladiator = null;
            double lowestDist = 100.0;
            double dist = 0;
            foreach (Gladiator glad in BattleTile.MyTeam)
            {
                try
                {
                    if (glad.State == State.alive)
                    {
                        dist = (int)Math.Sqrt(Math.Pow(glad.X - SelectedTile.X, 2) + Math.Pow(glad.Y - SelectedTile.Y, 2));
                        if (dist < lowestDist)
                        {
                            lowestDist = dist;
                            nearestTileWithPlayerGladiator = glad.CurrentTile;
                        }
                    }
                }
                catch
                {
                    return null;
                }
            }
            return nearestTileWithPlayerGladiator;
        }

        public void AIGladiatorTurn(BattleTile NearestTile)
        {
            if(NearestTile == null)
            {
                return;
            }
            if (SelectedTile.TileIsInAttackRange(NearestTile))
            {
                SelectedTile.AttackGladiator(SelectedTile, NearestTile, rtbBattleMonitor);
            }

            else if(SelectedTile.TileIsInMovementRange(NearestTile))
            {
                int XToMove = NearestTile.X - SelectedTile.X;
                if(XToMove > 0)
                {
                    XToMove--;
                }
                else if(XToMove < 0)
                {
                    XToMove++;
                }

                int YToMove = NearestTile.Y - SelectedTile.Y;
                if (YToMove > 0)
                {
                    YToMove--;
                }
                else if (YToMove < 0)
                {
                    YToMove++;
                }

                int targetX = SelectedTile.X + XToMove;
                int targetY = SelectedTile.Y + YToMove;

                BattleTile tileToMoveTo = ArenaField[targetX, targetY];

                if(!TargetTileOccupied(tileToMoveTo))
                {
                    SelectedTile.MoveGladiator(tileToMoveTo);
                }
                else
                {

                }
            }


          

        }


    }


    
}
