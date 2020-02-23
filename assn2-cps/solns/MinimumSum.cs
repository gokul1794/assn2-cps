using System;
using System.Collections.Generic;
using System.Text;

namespace assn2_cps.solns
{
    class MinimumSum
    {
        public static int MinimumSumSoln(int[] l2)
        {
            int sum;
            try
            {
                sum = l2[0];
                int i;

                for (i = 0; i < l2.Length - 1; i++)
                {
                    if (l2[i + 1] == l2[i])
                    {
                        l2[i + 1] = l2[i] + 1;
                        if (i < l2.Length - 2)
                        {
                            if (l2[i + 2] < l2[i + 1])
                            {
                                int c = l2[i + 1] - l2[i + 2];
                                l2[i + 2] = c + l2[i + 2];
                            }
                        }
                    }
                    sum = sum + l2[i + 1];
                }
            }
            catch (Exception e)
            {
                //Message in case list is empty. Sum of the array is 0
                Console.WriteLine($"Error: {e.GetType().Name}, check list has at least one value");
                sum = 0;
            }
            return sum;
        }

    }
}
