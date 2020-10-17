using System;
using static System.Math;

namespace AppDevLab1
{
    class Manager
    {
        public static double Calculate(double X, double Y, double Z)
        {
            return Log(Pow(Y, -Sqrt(Abs(X)))) *
                   (X - Y / 2) + Pow(Sin(Atan(Z)), 2);
        }

        public static double ConvertToDouble(string textValue)
        {
            try
            {
                double doubleValue = Convert.ToDouble(textValue);
                return doubleValue;
            }
            catch (System.FormatException)
            {
                throw new FormatException();
            }
        }
    }
}
