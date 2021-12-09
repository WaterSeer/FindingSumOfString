using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FindingSumOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = null;
            if (args != null && args.Count() > 0)
            {
                if (File.Exists(args[0]))
                {
                    path = args[0];
                }
            }

            while (!File.Exists(path))
            {
                Console.WriteLine("Введите путь к файлу:");
                path = Console.ReadLine();
            }

            using (StreamReader file = new StreamReader(path))
            {
                List<string> ls = new();
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    ls.Add(line);
                }

                Console.WriteLine("Номер строки с максимальной суммой элементов: " + ls.SumEveryString().MaxValue());

                List<int> brokenSymbolList = ls.SumEveryString().BrokenSymbolsInCollection();
                if (brokenSymbolList.First() != -1)
                {
                    var ret = string.Join(" ,", brokenSymbolList.Select(s => s.ToString()).ToArray());
                    Console.WriteLine("Номера строк в которых не встречаются не числовые элементы \n" + string.Join(", ", brokenSymbolList.Select(s => s.ToString())) + "\n");
                }
            }
        }
    }
}
