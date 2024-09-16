using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public class Servers
    {
        private List<string> serverList = new List<string>();
        private static Lazy<Servers> uniqueInstance = new Lazy<Servers>(() => new Servers());
        private Servers() { }
        public static Servers Instance
        {
            get
            {
                return uniqueInstance.Value;
            }
        }
        public bool AddServer(string server)
        {
            if (serverList.Contains(server) || !server.StartsWith("http")) return false;
            else
            {
                serverList.Add(server);
                return true;
            }
        }
        public void ShowServers(bool isHttps)
        {
            foreach (string server in serverList)
            {
                if ((isHttps && server.StartsWith("https")) ||
                    (!isHttps && server.StartsWith("http") && !server.StartsWith("https")))
                {
                    Console.WriteLine(server);
                }
            }
        }
    }
}
