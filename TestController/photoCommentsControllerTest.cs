using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestController
{
    [TestClass]
    public class photoCommentsControllerTest:EnvironmentTest
    {
        private string Uri = "api/comments";
        
        [TestMethod]
        public async Task GetPhotoAlbumSuccreesFully()
        {
            //arrange
            //act
            var response = await _client.GetAsync(Uri);
            //assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}