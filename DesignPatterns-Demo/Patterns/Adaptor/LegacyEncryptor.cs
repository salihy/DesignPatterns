using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Adaptor
{
    public class LegacyEncryptor
    {
        public string EncryptText(string text)
        {
            return "AA" + text;
        }

        public string DecryptText(string text)
        {
            return "AA" + text;
        }
    }
}
