using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Bridge
{
    public class Rectangle : Shape
    {
        private int _x1;
        private int _x2;
        private int _y1;
        private int _y2;

        public Rectangle(int x1, int y1, int x2, int y2, ColorApi graphicsApi) : base(graphicsApi)
        {
            _x1 = x1;
            _x2 = x2;
            _y1 = y1;
            _y2 = y2;
        }

        public override async Task draw()
        {
            Console.Write($@"Rectangle, x1: {_x1}, y1: {_y1}, x2: {_x2}, y2: {_y2} ");
            await graphicsApi.DrawColor();
        }
    }
}
