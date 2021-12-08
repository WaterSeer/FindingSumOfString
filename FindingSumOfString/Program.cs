using System;
using System.Collections.Generic;
using System.IO;

namespace FindingSumOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = null;
            if (args != null && File.Exists(args[0]))
            {
                path = args[0];
            }

            using (StreamReader file = new StreamReader(path))
            {
                while (!File.Exists(path))
                {
                    Console.WriteLine("Path:");
                    path = Console.ReadLine();                    
                }

                List<string> ls = new();
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    ls.Add(line);
                }

                Console.WriteLine("Max value position is: " + ls.SumEveryString().FindMaxIndexInCollection());
                Console.WriteLine("Broken symbol fided at positions: " + ls.SumEveryString().FindBrokenSymbolsInCollection());
                
                               
                
            }
        }
    }
}
