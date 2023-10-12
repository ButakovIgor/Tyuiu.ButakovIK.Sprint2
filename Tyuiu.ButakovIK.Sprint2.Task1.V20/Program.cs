using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint2.Task1.V20.Lib;

namespace Tyuiu.ButakovIK.Sprint2.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 242;
            int b = 155;
            int c = 456;
            int d = 17;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);
            Console.Title = "Спринт #2 | Выполнил: Бутаков И. К. | АСОиУб-23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Логические операции                                                  *");
            Console.WriteLine("* Таск: #1                                                                   *");
            Console.WriteLine("* Вариант: #20                                                               *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУб-23-1                       *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,            *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении) *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций не  *");
            Console.WriteLine("* должна нарушаться), а также арифметических выражений, которая вернёт       *");
            Console.WriteLine("* логическую последовательность(массив):                                     *");
            Console.WriteLine("* (False, False, False, True, True, True)                                    *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
