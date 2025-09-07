using Tyuiu.NazarovAA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.NazarovAA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"5 + 5 = {DataService.Addition(5, 5)}");
            Console.WriteLine($"5 - 2 = {DataService.Subtraction(5, 2)}");
            Console.WriteLine($"4 * 6 = {DataService.Multiplication(4, 6)}");
            
            //Console.WriteLine($"15 / 0 = {DataService.Division(15, 0)}"); //ошибка
            
            Console.WriteLine($"15 / 5 = {DataService.Division(15, 5)}");
        }
    }
}
