using System;
using System.Collections.Generic;
using System.Text;

namespace assn2_cps.solns
{
    class TargetRange
    {
        public static int[] TargetRangeSoln(int[] l1, int target)
        {
            int first = -1, final = -1; //if no target variable are found output: [-1,-1]
            try
            {
                int counter = 0;
                if (0 < l1.Length)
                {
                    for (int i = 0; i < l1.Length; i++)
                    {
                        if (counter == 0 && l1[i] == target)
                        {
                            //if only one number matches target on the list, it should populate as [first,final]
                            first = i;
                            final = i;
                            counter++;
                            continue;
                        }
                        if (counter > 0 && l1[i] == target) //change final value if more target variables are found in ascending array
                        {
                            final = i;
                        }
                    }
                }
                else
                {
                    //Note in case the list input is empty
                    Console.WriteLine($"Error: Check input for ordered list name:\"l1\". Current length is:{l1.Length}");
                }
            }
            catch (Exception e)
            {
                //Error info, in case of any errors
                Console.WriteLine($"Error: {e.GetType().Name}");
            }
            int[] result = { first, final };
            return result;
        }
    }
}
