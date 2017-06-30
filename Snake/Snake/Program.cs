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
            Console.SetWindowSize(150, 40);
            Console.CursorVisible = false;
            Console.Title = "Snake";
            Console.SetBufferSize(150, 40);

            HorizontalLine lineTopH = new HorizontalLine(0, 149, 0, '-');
            lineTopH.Draw();

            HorizontalLine lineDownH = new HorizontalLine(0, 149, 38, '-');
            lineDownH.Draw();

            VerticalLine lineLeftV = new VerticalLine(1, 37, 0, '#');
            lineLeftV.Draw();

            VerticalLine lineRightV = new VerticalLine(1, 37, 149, '#');
            lineRightV.Draw();

            Point tail = new Point(5, 7, '*');
            Snake snake = new Snake(tail, 10, Direction.LEFT);
            snake.Draw();
        }
    }
}
