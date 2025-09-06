using Tyuiu.NazarovAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.NazarovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            string name = "Артём";
            string res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Артём", res);
        }
    }
}
