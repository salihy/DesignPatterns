using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Composite
{
    public class OfficerCS : List<IMilitary>, IMilitary
    {
        public async Task execute()
        {
            foreach (var item in this) { 
                await item.execute();
            }
        }
    }
}
