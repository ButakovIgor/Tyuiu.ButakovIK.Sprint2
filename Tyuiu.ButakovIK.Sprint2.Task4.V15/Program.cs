using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint2.Task4.V15.Lib;

namespace Tyuiu.ButakovIK.Sprint2.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Таск #4                                                                 *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции        *");
            Console.WriteLine("* с использованием тернарного оператора, где пользователь вводит значение *");
            Console.WriteLine("* переменных x и y с клавиатуры, если:                                    *");
            Console.WriteLine("*    _        _                         2 2                               *");
            Console.WriteLine("*   √X / 2 > √Y - 20, то Z = ( 3 + 2 / Y )                                *");
            Console.WriteLine("*                          2                                              *");
            Console.WriteLine("*   иначе Cos(Y) + ( 12 / x )                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double z = ds.Calculate(x,y);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
