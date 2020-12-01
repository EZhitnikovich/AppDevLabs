using System;
using System.Collections.Generic;
using System.Text;

namespace LAB9
{
    interface IRows
    {
        List<double> Row(double xn, double xk, double h);
    }
}
