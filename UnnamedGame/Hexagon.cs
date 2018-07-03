using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace UnnamedGame
{
    class Hexagon
    {
        public Polygon hex;

        public Hexagon(int x, int y, int radius)
        {
            hex = new Polygon();
            hex.Stroke = Brushes.Black;
            hex.Fill = Brushes.PaleGreen;
            hex.StrokeThickness = 1;

            for(var i=0; i<6; i++)
            {
                double ang = i * 2 * Math.PI / 6;
                int vx = (int)Math.Round(x + radius * Math.Cos(ang));
                int vy = (int)Math.Round(y + radius * Math.Sin(ang));

                hex.Points.Add(new Point(vx, vy));
            }

        }
    }
}
