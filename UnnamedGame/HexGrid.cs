using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace UnnamedGame
{
    class HexGrid : Canvas
    {

        public HexGrid()
        {
            for (var j = 0; j < 15; j++)
            {
                for (var i = 0; i < 10; i++)
                {

                    Point po = EvenqOffsetToPixel(j, i, 10);
                    System.Diagnostics.Trace.WriteLine(po.X + " " + po.Y);
                    this.Children.Add(new Hexagon((int)po.X + 15, (int)po.Y + 20, 10).hex);
                }
            }


        }

        public static Point EvenqOffsetToPixel(int x, int y, int r)
        {
            int vy = (int)(r * Math.Sqrt(3) * (y - 0.5 * (x % 2)));

            int vx = (int)(r * 3 / 2 * x);
            return new Point(vx, vy);
        }
    }

}
