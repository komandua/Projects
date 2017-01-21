using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string> {"this is line1",
                            "this is line2",
                            "this is line3",
                            "this is line2"};
            CheckDuplicates(data);
            Console.ReadLine();
        }


        public static bool CheckDuplicates(List<string> data)
        {
            bool bExists = false;
            HashSet<string> hs = new HashSet<string>();
            foreach (string e in data)
            {
                if (hs.Contains(e))
                {
                    bExists = true;
                    Console.WriteLine("Duplicate" + e);
                }
                else
                    hs.Add(e);
            }
            return bExists;

         }
    }
}
