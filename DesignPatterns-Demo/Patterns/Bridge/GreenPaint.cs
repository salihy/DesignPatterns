using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Bridge
{
    public class GreenPaint : ColorApi
    {
        public async Task DrawColor()
        {
            Console.WriteLine($@", Color: Green");
        }
    }
}
