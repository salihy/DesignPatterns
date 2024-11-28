using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns.Adaptor
{
    public interface IEncryption
    {
        Task<string> Encrypt(string input);
        Task<string> Decrypt(string input);
    }
}
