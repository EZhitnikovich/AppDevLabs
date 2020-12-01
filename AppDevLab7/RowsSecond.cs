using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace LAB7
{
    class RowsSecond : IRows
    {
        public List<double> Row(double xn, double xk, double h)
        {
            List<double> rowList = new List<double>() { };

            double f, sum;
            while (xn <= xk)
            {

                f = 1;
                sum = f;
                int n = 0;

                while (n < 500)
                {
                    f *= Pow(xn, 2) / (2 * n + 2);
                    sum += f;
                    n++;
                }

                rowList.Add(sum);
                xn += h;
                xn = Round(xn, 2);
            }
            return rowList;
        }
    }
}
