using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };


            for (int k = 0; k < arr.GetUpperBound(0)+1; k++)
            {
                int t = 0;
                for (int i = 0; i < arr.GetUpperBound(1)+1; i++)
                {
                    for (int j = i + 1; j < arr.GetUpperBound(1)+1; j++)
                    {
                        if (arr[k,i] > arr[k,j])
                        {
                            t = arr[k,i];
                            arr[k,i] = arr[k,j];
                            arr[k,j] = t;


                        }
                    }
                }
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
