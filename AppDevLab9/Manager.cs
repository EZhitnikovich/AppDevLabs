using System;
using System.Collections.Generic;
using static System.Math;

namespace LAB9
{
    class Manager
    {
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
