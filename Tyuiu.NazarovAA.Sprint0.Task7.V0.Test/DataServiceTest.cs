using Tyuiu.NazarovAA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.NazarovAA.Sprint0.Task7.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            int[] array1 = { 1, 1, 1, 1, 1 };
            int[] array2 = { 1, 1, 1, 1, 1 };

            int[] array3 = { 2, 2, 2, 2, 2 };

            CollectionAssert.AreEqual(array3, DataService.AdditionArrays(array1, array2));
        }
    }
}
