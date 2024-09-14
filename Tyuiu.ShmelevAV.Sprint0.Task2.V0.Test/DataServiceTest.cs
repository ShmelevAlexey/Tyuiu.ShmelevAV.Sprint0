using Tyuiu.ShmelevAV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ShmelevAV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Alexey";

            var res = DataService.GetMessage(name);

            Assert.AreEqual("Hi..., Alexey", res);
        }
    }
}