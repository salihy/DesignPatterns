using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Composite
{
    public class Officer : IMilitary
    {
        public Officer()
        {
            _soldiers = new List<IMilitary>();
        }

        private List<IMilitary> _soldiers { get; set; }

        public async Task Add(IMilitary item)
        {
            _soldiers.Add(item);
        }
        public async Task Remove(IMilitary item)
        {
            _soldiers.Remove(item);
        }
        public async Task<List<IMilitary>> GetChildren()
        {
            return _soldiers;
        }

        public async Task execute()
        {
            foreach (var item in _soldiers) { 
                await item.execute();
            }
        }
    }
}
