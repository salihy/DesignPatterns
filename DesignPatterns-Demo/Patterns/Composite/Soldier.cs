using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Composite
{
    public class Soldier : IMilitary
    {
        public async Task execute()
        {
            System.Console.WriteLine("asker islemi gerceklestirdi!");
        }
    }
}
