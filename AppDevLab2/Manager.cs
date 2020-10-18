using System;

namespace AppDevLab2
{
    class Manager
    {
        public static double ConvertToDouble(string textValue)
        {
            try
            {
                return Convert.ToDouble(textValue);
            }
            catch (System.FormatException)
            {
                throw new Exception("Incorrect data");
            }
        }

        public static int ConvertToInt(string textValue)
        {
            try
            {
                return Convert.ToInt32(textValue);
            }
            catch (System.FormatException)
            {
                throw new Exception("Incorrect data");
            }
        }
    }
}
