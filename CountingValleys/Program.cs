using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        static int countingValleys(int n, string s)
        {
            int valleysCounter=0, uCounter=0, dCounter =0;
            for (int i = 0; i < s.Length; i++)
            {
                var element = s[i];
                if (element == 'U') uCounter++;
                else dCounter++;

                if (dCounter > uCounter)
                {
                    while (uCounter != dCounter)
                    {
                        i++;
                        element = s[i];
                        if (element == 'U') uCounter++;
                        else dCounter++;
                    }
                    valleysCounter += 1;
                }
            }
            return valleysCounter;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            Console.WriteLine("Valleys count ="+result.ToString());
            Console.ReadKey();
        }
    }
}
