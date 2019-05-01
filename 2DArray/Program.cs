using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    class Program
    {
        static int hourglassSum(int[][] arr)
        {
            var highestValue = 0;
            bool isFirst = true;
            for (var z = 0; z < 4; z++) // y motion
            {
                for (int t = 0; t < 4; t++)// x motion
                {
                    var sum = 0;
                    for (int i = z; i < z + 3; i++)// y motion 3 step
                    {
                        for (var j = t; j < t + 3; j++)// x motion 3 step
                        { 
                            if ((i-z) == 1) // value equal 0,1,2 
                            {
                                if ((j-t) == 1) // value equal 0,1,2
                                    sum += arr[i][j];
                                // if (1,1) sum because hourglass symbol
                                //1 1 1
                                //0 1 0
                                //1 1 1 
                                //just sum 1 for this example.
                            }
                            else sum += arr[i][j];
                        }
                    }
                    if (isFirst)
                    {
                        isFirst = false;
                        highestValue = sum;
                    }
                    else if (highestValue < sum)
                        highestValue = sum;
                }
                
            }
            return highestValue;
        }
        

        static void Main(string[] args)
        {

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
