using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint2.Task0.V4.Lib;

namespace Tyuiu.ButakovIK.Sprint2.Task0.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 333;
            int y = 324;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #2 | Выполнил: Бутаков И. К. | АСОиУб-23-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Тема: Операции сравнения                                                  *");
            Console.WriteLine("* Таск: #0                                                                  *");
            Console.WriteLine("* Вариант: #4                                                               *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУб-23-1                      *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу из операций сравнений                                  *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)  *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность: *");
            Console.WriteLine("* (False, True, Falsе, True, False, True)                                   *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
