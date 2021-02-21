

using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestController
{
    [TestClass]
    public class UsersControllerTest:EnvironmentTest
    {
        private string Uri = "api/users";

        [TestMethod]
        public async Task GetUsersSuccessfully()
        {
            //arrange
            //act
            var response = await _client.GetAsync(Uri);
            //assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}