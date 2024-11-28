using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DesignPatterns_Demo.Patterns.Adaptor
{
    public class RSAEncryption : IEncryption
    {
        public async Task<string> Decrypt(string input)
        {
            return "RSA" + input;
        }

        public async Task<string> Encrypt(string input)
        {
            return "RSA" + input;
        }
    }
}
