using Tyuiu.NazarovAA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.NazarovAA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(15, DataService.AdditionArray(ints));
        }
        [TestMethod]
        public void CheckSubtractionArrayValid()
        {
            int[] ints = { 5, 1, 3 };
            Assert.AreEqual(1, DataService.SubtractionArray(ints));
        }
        [TestMethod]
        public void CheckMultiplicationArrayValid()
        {
            int[] ints = { 1, 2, 3, 4 };
            Assert.AreEqual(24, DataService.MultiplicationArray(ints));
        }
    }
}
