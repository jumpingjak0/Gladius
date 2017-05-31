using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class BattleField
    {
        public int ID;
        public int[,] Field;

        public BattleField(int id, string coordinates, int width, int height) 
        {
            ID = id;
            int[,] field = new int[width, height];
            char[] coords = coordinates.ToCharArray();

            int i = 0;
            for(int j = 0; j < height; j++)
            {
                for(int k = 0; k < width; k++)
                {
                    field[k, j] = (int)Char.GetNumericValue(coords[i]);
                    i++;
                }
            }
            Field = field;
        }
    }
}
