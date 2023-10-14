using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.ButakovIK.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1

    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool isUpperHalf = y >= 0;
            bool betweenLines = y >= Math.Abs(x);
            bool insideCircle = x * x + y * y <= 1;

            return betweenLines && insideCircle && isUpperHalf;
        }
    }
}
