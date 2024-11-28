using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Bridge
{
    public class RedPaint : ColorApi
    {
        public async Task DrawColor()
        {
            Console.WriteLine($@", Color: Red");
        }
    }
}
