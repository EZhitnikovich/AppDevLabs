using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevLab4
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
