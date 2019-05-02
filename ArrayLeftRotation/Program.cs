using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLeftRotation
{
    class Program
    {
        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int[] newArray = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                var newIndex = (i - d) >= 0 ? i - d : (i - d) + a.Length;
                newArray[newIndex] = a[i];
            }
            return newArray;
        }

        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
