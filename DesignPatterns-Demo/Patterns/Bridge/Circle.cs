using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Bridge
{
    public class Circle : Shape
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius, ColorApi graphicsApi) : base(graphicsApi)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            
        }
        public override async Task draw()
        {
            Console.Write($@"Circle, x: {x}, y: {y}, radius: {radius} ");
            await graphicsApi.DrawColor();
        }
    }
}
