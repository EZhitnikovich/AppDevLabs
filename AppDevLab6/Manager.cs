using System;

namespace LAB6
{
    class Manager
    {
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
