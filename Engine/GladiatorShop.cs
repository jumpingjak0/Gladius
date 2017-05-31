using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class GladiatorShop : Shop
    {
        
        public List<Gladiator> Stock;

        public GladiatorShop(int id, string name, string vendorName, string description, List<Gladiator> stock): base(id, name, description, vendorName)
        {
            
            Stock = stock;
        }

        public string PurchaseGladiator (Gladiator boughtGladiator)
        {
            if (boughtGladiator.Value < Player.Gold)
            {
                boughtGladiator.InPlayersTeam = true;
                Player.MySchool.Add(boughtGladiator);
                Gladiator gladToRemove = null;
                foreach (Gladiator glad in Stock)
                {
                    if (boughtGladiator.Name == glad.Name)
                    {
                        gladToRemove = glad;
                        break;
                    }
                }
                Stock.Remove(gladToRemove);
                Player.Gold -= boughtGladiator.Value;
                string output = "You have bought " + gladToRemove.Name + " for " + gladToRemove.Value + "gold.";
                return output;
            }
            else
            {
                return "You can't afford this gladiator.";
            }
            
            
               
        }
    }
}
