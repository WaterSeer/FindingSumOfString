using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingSumOfString
{
    public static class TextService
    { 
        public static float SumOfString(string line)
        {
            return line.Split(",").Select(f => float.Parse(f)).Sum(s => s);
        }        

        public static List<float> SumEveryString(this List<string> stringList)
        {
            List<float> result = new();
            foreach (var item in stringList)
            {
                try
                {
                    result.Add(TextService.SumOfString(item));
                }
                catch (Exception)
                {
                    result.Add(float.NaN);
                }
            }
            return result;
        }
        
        public static int FindMaxIndexInCollection(this List<float> floatList)
        { 
            return floatList.IndexOf(floatList.Max());
        }

        public static List<int> FindBrokenSymbolsInCollection(this List<float> floatList)
        {
            int index = 0;
            List<int> result = new();
            foreach (var item in floatList)
            {
                if (float.IsNaN(item))
                {
                    result.Add(index);
                }
                index++;
            }
            return result;
        }

    }
}
