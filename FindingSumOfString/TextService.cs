using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FindingSumOfString
{
    public static class TextService
    {
        public static float SumOfString(string line)
        {
            if (line == null)
                return float.NaN;
            return line.Split(",").Select(f => float.Parse(f, CultureInfo.InvariantCulture)).Sum(s => s);
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

        public static int MaxValue(this List<float> list)
        {
            if (list == null || list.Count == 0)
                return 0;
            return list.IndexOf(list.Max()) + 1;
        }

        public static List<int> BrokenSymbolsInCollection(this List<float> list)
        {
            int index = 0;
            List<int> result = new();
            foreach (var item in list)
            {
                if (float.IsNaN(item))
                {
                    result.Add(index);
                }
                index++;
            }
            if (result.Count == 0)
            {
                result.Add(-1);
                return result;
            }
            return result.Select(s => s + 1).ToList();
        }
    }
}
