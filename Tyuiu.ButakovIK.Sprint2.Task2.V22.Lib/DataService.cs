using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ButakovIK.Sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x >= 3) && (x <= 5) && (y >= 3) && (y <= 7)) || ((x >= 6) && (x <= 8) && (y >= 5) && (y <= 7)) || ((x >= 9) && (x <= 12) && (y >= 3) && (y <= 7)) || ((x >= 9) && (x <= 10) && (y >= 8) && (y <= 9)) || ((x == 13) && (y >= 6) && (y <= 8)) || ((x == 12) && (y >= 8) && (y <= 11)) || ((x >= 4) && (x <= 6) && (y >= 8) && (y <= 11)) || ((x == 3) && (y == 11)) || ((x == 5) && (y >= 12) && (y <= 13)) || ((x >= 4) && (x <= 10) && (y == 14)))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
