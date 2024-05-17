using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4._3._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, -3, -33 };

            int pos = 0;

            foreach (int i in arr)
            {
                if (i > 0) pos += 1;
            }
            Console.WriteLine(pos);
        }
    }
}
