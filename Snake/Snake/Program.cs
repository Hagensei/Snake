using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 6, 'X');
            p1.Draw();

            HorizontalLine lineH = new HorizontalLine(3, 20, 2, '-');
            lineH.Draw();

            VerticalLine lineV = new VerticalLine(2, 10, 3, '|');
            lineV.Draw();
        }
    }
}
