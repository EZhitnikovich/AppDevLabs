using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace LAB7
{
    public static class OutputService
    {
        public static string PrintRowAndForm(double X1, double X2, int N, double h, List<double> rowList, IFormulae formulae)
        {
            string text = null;
            text += $"X1 = {X1}\r\n" +
                                      $"X2 = {X2}\r\n" +
                                      $"N = {N}\r\n" +
                                      $"H = {h}\r\n";

            text += "X\t|\tРяд\t|\tФормула\r\n";

            for (int i = 0; i < rowList.Count; i++, X1 += h)
            {
                text += Round(X1, 2) + "\t|\t" + Round(rowList[i], 5) + "\t|\t" + Round(formulae.Formula(X1), 5) + "\r\n";
            }

            return text;
        }
    }
}
