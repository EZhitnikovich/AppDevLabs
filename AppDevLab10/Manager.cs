using System.Collections.Generic;
using System.Linq;

namespace LAB10
{
    class Manager
    {
        public static List<string> GetOddGroups(string originalText)
        {
            List<string> finalArray = new List<string>() { };

            finalArray = originalText.Split(' ').ToList();

            foreach (string s in finalArray.ToArray())
            {
                if (s.Length % 2 != 1)
                {
                    finalArray.Remove(s);
                }
            }

            return finalArray;
        }

        public static int CalculateUnits(string element)
        {
            //int quantity = element.Count(x => x == '1');

            int quantity = 0;

            for(int i = 0; i < element.Length; i++)
            {
                if(element[i] == '1')
                {
                    quantity++;
                }
            }

            return quantity;
        }
    }
}
