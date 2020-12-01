using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace LAB9
{
    class FormulaeFirst : IFormulae
    {
        public double Formula(double x)
        {
            return (1 + 2 * Pow(x, 2)) * Pow(E, Pow(x, 2));
        }
    }
}
