using Tyuiu.NazarovAA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.NazarovAA.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 1, 2, 3, 4, 5 };

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #0                                                                      *");
            Console.WriteLine("* Тема: создание итогового решения по скрипту                                    *");
            Console.WriteLine("* Задание #7                                                                     *");
            Console.WriteLine("* Вариант #0                                                                     *");
            Console.WriteLine("* Выполнил: Назаров Артём Александрович | СППб-25-1                              *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать консольную программму на C#, которая суммирует значения двух          *");
            Console.WriteLine("* одинаковых массивов по длине                                                   *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Значения элементов массива №1:");
            Console.WriteLine(string.Join(", ", array1));
            Console.WriteLine("Значения элементов массива №2:");
            Console.WriteLine(string.Join(", ", array2));
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Сумма элементов массива равна:");
            Console.WriteLine(string.Join(", ", DataService.AdditionArrays(array1, array2)));

        }
    }
}
