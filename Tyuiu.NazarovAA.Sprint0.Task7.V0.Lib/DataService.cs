namespace Tyuiu.NazarovAA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] array1, int[] array2)
        {
            int[] array3 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
            }
            return array3;
        }
    }
}
