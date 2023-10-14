using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint2.Task3.V10.Lib;

namespace Tyuiu.ButakovIK.Sprint2.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Таск #3                                                                 *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит    *");
            Console.WriteLine("* значение переменной X с клавиатуры.                                     *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой.             *");
            Console.WriteLine("*          .                                                              *");
            Console.WriteLine("*         |                      x                                        *");
            Console.WriteLine("*         |x - ( x + 15 / x - 4 )  , если x > 0                           *");
            Console.WriteLine("*         |                                                               *");
            Console.WriteLine("*         | 2        2         2        2                                 *");
            Console.WriteLine("*         |x + cos( X ) - 3 / x - sin( X ) + 2, если x = 0                *");
            Console.WriteLine("*    y = <                                                                *");
            Console.WriteLine("*         |           2 2                                                 *");
            Console.WriteLine("*         |( 5 + 1 / x ), если -14 < x < 0                                *");
            Console.WriteLine("*         |                                                               *");
            Console.WriteLine("*         |x + 10x - (1/x), если x < -14                                  *");
            Console.WriteLine("*         |                                                               *");
            Console.WriteLine("*          '                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double y = ds.Calculate(x);
            Console.WriteLine(y);
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}






