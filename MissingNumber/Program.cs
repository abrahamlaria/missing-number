using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    class Program
    {
        public static int FindMissing(int[] array, int n)
        {
            var total = n*(n+1)/2; // 1+2+3+ ... +n = n*(n+1) this can be proved by math induction.

            for (int i = 0; i < n-1; i++)
            {
                total -= array[i];
            }

            return total;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 4, 5, 6 };
            Console.Write(FindMissing(array, 5));
            Console.ReadLine();
        }
    }
}
