using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint2.Task5.V6.Lib;

namespace Tyuiu.ButakovIK.Sprint2.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Оператор switch                                                      *");
            Console.WriteLine("* Таск #5                                                                    *");
            Console.WriteLine("* Вариант #6                                                                 *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                       *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:       *");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3, масти «червы» — 4, *");
            Console.WriteLine("* а достоинству карт: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14 *");
            Console.WriteLine("* (порядковые номера карт остальных достоинств соответствуют их названиям:   *");
            Console.WriteLine("* «шестерка», «девятка» и т. п.).                                            *");
            Console.WriteLine("* По заданным номеру масти m (1 <= m <= 4) и номеру достоинства карты        *");
            Console.WriteLine("* k (6 <= k <= 14) определить полное название (масть и достоинство)          *");
            Console.WriteLine("* соответствующей карты в виде «Дама пик», Шестерка бубен» и т. п.           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Введите число от 1 до 4:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число от 6 до 14:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            try
            {
                string cardnum = ds.FindCardNameAndValue(x, y);
                Console.WriteLine(cardnum);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
