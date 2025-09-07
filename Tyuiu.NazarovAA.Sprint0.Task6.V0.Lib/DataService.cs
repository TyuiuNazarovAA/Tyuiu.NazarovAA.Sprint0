namespace Tyuiu.NazarovAA.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static int AdditionArray(int[] ints) //for
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }
            return sum;
        }
        public static int SubtractionArray(int[] ints) //while
        {
            int sub = ints[0];
            int index = 1;
            while (ints.Length > index)
            {
                sub -= ints[index];
                index++;
            }
            return sub;
        }
        public static int MultiplicationArray(int[] ints) //do...while
        {
            int multi = 1;
            int index = 0;
            do
            {
                multi *= ints[index];
                index++;
            } while (index < ints.Length);
            return multi;
        }
    }
}
