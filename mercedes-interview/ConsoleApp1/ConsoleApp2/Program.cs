using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(2 == getMinDeletions("abcab"));
            Console.WriteLine(2 == getMinDeletions("abab"));
            Console.WriteLine(3 == getMinDeletions("abcabc"));
            Console.WriteLine(11 == getMinDeletions("abzwehassbffzaaeh"));



            //Console.WriteLine(removeStringFromIndexToIndex(0,2,"abcab"));

        }


        static bool checkIsDistinct(string str)
        {
            if (str == "") return false;

            for (int i = 0; i < str.Length; i++)
            {
                var firstItem = str[i];
                for (int j = 0; j < str.Length; j++)
                {
                    if (i!=j && firstItem == str[j]) return false;
                }

            }
          
            return true;

        }
        static string removeStringFromIndexToIndex(int start, int step, string str)
        {
            var s = "";
            var end = start + step -1;
            for (int i = 0; i < str.Length; i++)
            {
                if(i<start || i> end)
                {
                    s += str[i];
                }
            }
            return s;
        }

        static int getMinDeletions(string str)
        {
            var min = str.Length;
            for (int i = 1; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length-i; j++)
                {
                    var removed = removeStringFromIndexToIndex(j, i, str);
                    var checkValue = checkIsDistinct(removed);
                    if (checkValue){
                        if(min > i)
                        {
                            min = i;
                        }
                    }
                }
            }
            return min;
        }

    }
}
