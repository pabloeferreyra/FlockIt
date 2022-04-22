using FlockIt.Controllers;
using FlockIt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace FlockIt_test
{
    public class UnitTest1
    {
        [Fact]
        public void NotNullControllerTest()
        {
            var services = new ServiceCollection();
            var serviceProvider = services.BuildServiceProvider();

            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var provincesController = new ProvincesController(config);

            Assert.NotNull(provincesController);
        }

        [Theory]
        [InlineData("Santa Fe")]
        public void GetProvinceTest(string name)
        {
            var services = new ServiceCollection();
            var serviceProvider = services.BuildServiceProvider();

            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var provincesController = new ProvincesController(config);
            var province = provincesController.GetAsync(name);
            Assert.NotNull(province);
        }

        [Fact]
        public void LoginTestTrue()
        {
            var loginController = new LoginController();
            User user = new User
            {
                Id = 01,
                Name = "Cosme",
                Surname = "Fulanito",
                Username = "alguien 123"
            };
            var userResult = loginController.Post(user);
            Assert.NotNull(userResult);
        }
    }
}