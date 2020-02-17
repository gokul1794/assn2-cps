using System;
using System.Collections.Generic;
using System.Text;

namespace assn2_cps.solns
{
    class TargetRange
    {
        public static int[] TargetRangeSoln(int[] l1, int target)
        {
            int first=-1, final=-1;
            int counter = 0;
            for (int i=0; i < l1.Length; i++)
            {
                if (counter == 0 && l1[i] == target)
                {
                    first = i;
                    final = i;
                    counter++ ;
                    continue;
                }
                if (counter > 0 && l1[i] == target)
                {
                    final = i;
                }
            }
            int[] result = { first, final };
            return result;
        }
    }
}
