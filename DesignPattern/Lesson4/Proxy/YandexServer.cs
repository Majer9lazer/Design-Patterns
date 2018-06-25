using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson4.Proxy
{
    internal class YandexServer:IServer
    {
        private readonly string _url;
        public YandexServer(string url)
        {
            _url = url;
            Connect();
        }
        public void ProcessRequest()
        {
            Console.WriteLine("Processing request to "+_url);
        }

        private void Connect()
        {
            Console.WriteLine("Connect to "+_url);
        }
    }
}
