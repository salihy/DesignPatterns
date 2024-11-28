using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Adaptor
{
    public class LegacyEncryptionAdaptor : IEncryption
    {
        private LegacyEncryptor encryptor;

        public LegacyEncryptionAdaptor()
        {
            encryptor = new LegacyEncryptor();
        }

        public async Task<string> Decrypt(string input)
        {
            return encryptor.DecryptText(input);
        }

        public async Task<string> Encrypt(string input)
        {
            return encryptor.EncryptText(input);
        }
    }
}
