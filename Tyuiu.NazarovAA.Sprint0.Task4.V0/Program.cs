using Tyuiu.NazarovAA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.NazarovAA.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(5, 5));
            Console.WriteLine(DataService.Subtraction(6, 1));
            Console.WriteLine(DataService.Multiplication(5, 5));
            Console.WriteLine(DataService.Division(25, 5));

        }
    }
}
