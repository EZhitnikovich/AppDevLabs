using System;
using System.Collections.Generic;
using static System.Math;

namespace AppDevLab3
{
    class Manager
    {
        public static List<double> Row(double xn, double xk, double h)
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

        public static double Formula(double x)
        {
            return (1 + 2 * Pow(x, 2)) * Pow(E, Pow(x, 2));
        }

        public static double ConvertToDouble(string textValue)
        {
            try
            {
                return Convert.ToDouble(textValue);
            }
            catch (FormatException)
            {
                return 0;
            }
        }

        public static int ConvertToInt(string textValue)
        {
            try
            {
                return Convert.ToInt32(textValue);
            }
            catch (FormatException)
            {
                return 0;
            }
        }
    }
}
