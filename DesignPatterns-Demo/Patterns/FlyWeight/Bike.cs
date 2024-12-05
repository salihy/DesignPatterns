using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.FlyWeight
{
    public class Bike : IVehicle
    {
        private List<Color> _colors = new List<Color>();

        public void AddColor(Color c)
        {
            _colors.Add(c);
        }
    }
}
