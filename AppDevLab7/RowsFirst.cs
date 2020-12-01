using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace LAB7
{
    class RowsFirst : IRows
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

                while (n < 5)
                {
                    f *= (2 * n + 3) * Pow(xn, 2) / (2 * Pow(n, 2) + 3 * n + 1);
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
