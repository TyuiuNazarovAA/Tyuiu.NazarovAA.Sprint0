using Tyuiu.NazarovAA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.NazarovAA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма элементов массива: " + DataService.AdditionArray(ints));
            Console.WriteLine("Разность элементов массива: " + DataService.SubtractionArray(ints));
            Console.WriteLine("Произведение элементов массива: " + DataService.MultiplicationArray(ints));

        }
    }
}
