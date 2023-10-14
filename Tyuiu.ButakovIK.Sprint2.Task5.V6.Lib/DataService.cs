using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ButakovIK.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string num;
            switch (value1)
            {
                case 1:
                    num = "пик";
                    break;
                case 2:
                    num = "треф";
                    break;
                case 3:
                    num = "бубен";
                    break;
                case 4:
                    num = "черви";
                    break;
                default:
                    throw new ArgumentException($"Масти должны быть от 1 до 4. Значение {value1}");

            }
            string card;
            switch (value2)
            {
                case 6:
                    card = "шестёрка";
                    break;
                case 7:
                    card = "семёрка";
                        break;
                case 8:
                    card = "восьмёрка";
                    break;
                case 9:
                    card = "девятка";
                    break;
                case 10:
                    card = "десятка";
                    break;
                case 11:
                    card = "валет";
                    break;
                case 12:
                    card = "дама";
                    break;
                case 13:
                    card = "король";
                    break;
                case 14:
                    card = "туз";
                    break;
                default:
                    throw new ArgumentException($"Номер карты должн быть от 6 до 14. Значение {value2}");
            }
            return card + " " + num;
        }
    }
}
