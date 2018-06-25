using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson4.Proxy
{
    internal class ProxyServer : IServer
    {
        private readonly string _url;
        private YandexServer _yandexServer;
        public ProxyServer(string url)
        {
            _url = url;
        }
        public void ProcessRequest()
        {
            if (_yandexServer == null)
                _yandexServer = new YandexServer(_url);
            _yandexServer.ProcessRequest();
        }

    }
}
