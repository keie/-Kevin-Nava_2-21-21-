using System.Net.Http;
using ApiProject;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serilog;

namespace TestController
{
    [TestClass]
    public class EnvironmentTest
    {
        public readonly TestServer _server;
        public readonly HttpClient _client;

        public EnvironmentTest()
        {
            _server = new TestServer(WebHost.CreateDefaultBuilder()
                .UseSetting("https_port", "443")
                .UseSerilog()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
           
        }
    }
}