using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        static long repeatedString(string s, long n)
        {
            var aCountInS = counter(s);
            var simpleAcount = (n / s.Length) * aCountInS;
            for (int i = 0; i < n % s.Length; i++)
                if (s[i] == 'a')
                    simpleAcount++;

            return simpleAcount;
        }
        static long counter(string s)
        {
            var first = s.IndexOf('a');
            var counter = 0;
            while (first != -1)
            {
                counter++;
                first = s.IndexOf('a', first+1);
            }
            return counter;
        }   

        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);
            Console.WriteLine("res="+ result);
            Console.ReadKey();
        }
    }
}
 