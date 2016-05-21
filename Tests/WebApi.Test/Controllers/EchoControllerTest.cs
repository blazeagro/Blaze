using Blaze.Services.User.WebApi.Controllers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blaze.Services.User.WebApi.Test.Controllers
{
    [TestClass]
    public class EchoControllerTest
    {
        [TestMethod()]
        public void EchoController_Get_Positive()
        {
            var controller = ControllerUtil.SetupController<EchoController>(new EchoController());
            var response = controller.Get("Test");

            response.Should().Equals("Test");
        }
    }
}
