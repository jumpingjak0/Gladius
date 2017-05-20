using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        
        static Random rnd = new Random();

        public static int RandomNumber(int min, int max)
        {
            return rnd.Next(min, max);
        }

    }
}
