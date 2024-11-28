using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Adaptor
{
    internal class DESEnccryption : IEncryption
    {
        public async Task<string> Decrypt(string input)
        {
            return "DES" + input;
        }

        public async Task<string> Encrypt(string input)
        {
            return "DES" + input;
        }
    }
}
