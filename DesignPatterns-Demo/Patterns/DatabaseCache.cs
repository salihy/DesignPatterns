using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Demo.Patterns
{
    //Singleton
    public class DatabaseCache
    {
        private static DatabaseCache _instance;
        private static object _instanceLock = new object();

        private Dictionary<string, string> _userTableCache = new Dictionary<string, string>();

        private DatabaseCache()
        {
        }

        public static DatabaseCache GetInstance()
        {
            if (_instance != null) return _instance;

            lock (_instanceLock)
            {
                if (_instance == null)
                {
                    _instance = new DatabaseCache();
                }
            }

            return _instance;
        }

        public async Task AddUserToCache(string key, string val)
        {
            _userTableCache.Add(key, val);
        }

        public async Task<string> GetUser(string key)
        {
            return _userTableCache[key];
        }
    }
}
