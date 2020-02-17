using System;
using System.Collections.Generic;
using System.Text;

namespace assn2_cps.solns
{
    class TargetRange
    {
        public static int[] TargetRangeSoln(int[] l1, int target)
        {
            int first=-1, final=-1; //if no target variable are found output: [-1,-1]
            int counter = 0;
            for (int i=0; i < l1.Length; i++)
            {
                if (counter == 0 && l1[i] == target)
                {
                    //if only one number matches target on the list, it should populate as [first,final]
                    first = i; 
                    final = i;
                    counter++ ;
                    continue;
                }
                if (counter > 0 && l1[i] == target) //change final value if more target variables are found in ascending array
                {
                    final = i;
                }
            }
            int[] result = { first, final };
            return result;
        }
    }
}
