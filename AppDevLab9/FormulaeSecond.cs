using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;


namespace LAB9
{
    class FormulaeSecond : IFormulae
    {
        public double Formula(double x)
        {
            return (Pow(E, x) + Pow(E, -x))/2;
        }
    }
}
