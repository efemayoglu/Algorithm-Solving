using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheClouds
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            var jumpingCounter = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (i + 1 == c.Length) break;
                else if (i + 2 < c.Length && c[i + 2] == 0) i++;
                jumpingCounter++;
            }
            return jumpingCounter;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);


            Console.WriteLine("result="+ result);
            Console.ReadKey();
        }
    }
}
