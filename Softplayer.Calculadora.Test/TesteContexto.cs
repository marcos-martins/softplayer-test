using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace Softplayer.Calculadora.Test
{
    public class TesteContexto
    {
        public HttpClient Client { get; set; }
        private TestServer _server;
        public TesteContexto()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = _server.CreateClient();
        }
    }
}