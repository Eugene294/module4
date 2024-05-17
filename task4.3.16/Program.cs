using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4._3._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int pos = 0;

            foreach (int i in arr)
            {
                if (i > 0) pos += 1;
            }
            Console.WriteLine(pos);
        }
    }
}
