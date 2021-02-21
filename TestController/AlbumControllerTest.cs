using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestController
{
     [TestClass]
    public class AlbumControllerTest:EnvironmentTest
    {
        private string Uri = "api/albums";

        [TestMethod]
        public async Task GetAlbumSuccreesFully()
        {
            //arrange
            //act
            var response = await _client.GetAsync(Uri);
            //assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
        
        
    }
}