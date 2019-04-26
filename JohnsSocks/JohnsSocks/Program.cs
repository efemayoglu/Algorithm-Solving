using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnsSocks
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {

            var sum = 0.0;
            var ls = new List<int>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (ls.IndexOf(ar[i]) == -1)
                {
                    sum += Math.Floor(Convert.ToDouble(ar.Count(z => z.Equals(ar[i])) / 2));
                    ls.Add(ar[i]);
                }
            }

            return Convert.ToInt32( sum);
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);
 
        }
    }
}
