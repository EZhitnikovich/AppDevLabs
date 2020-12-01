using System;
using static System.Math;

namespace LAB8
{
    class Manager
    {
        public static double Calculate(double X, double Y, double Z)
        {
            return Log(Pow(Y, -Sqrt(Abs(X)))) * (X - Y / 2) + Pow(Sin(Atan(Z)), 2);
        }

        public static double ConvertToDouble(string textValue)
        {
            if (double.TryParse(textValue, out double result))
                return result;
            else
                return 1;
        }
    }
}
