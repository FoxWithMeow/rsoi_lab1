using Microsoft.VisualStudio.TestTools.UnitTesting;
using rsoi_lab1;
using rsoi_lab1.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace rsoi_lab1_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HomeController controller = new HomeController();
            var result = controller.Get(2, 4).Value;
            Assert.AreEqual(8, result);
        }
    }
}
