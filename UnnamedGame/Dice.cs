using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    class Dice
    {
        private static Random _random = new Random();


        public static int D(int n)
        {
            return _random.Next(n) + 1;
        }

    }
}
