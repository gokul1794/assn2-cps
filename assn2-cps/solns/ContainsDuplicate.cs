using System;
using System.Collections.Generic;
using System.Text;

namespace assn2_cps.solns
{
    class ContainsDuplicate
    {
        public static bool ContainsDuplicateSoln(char[] arr, int k)
        {
            try
            {
                Dictionary<char, int> myDict = new Dictionary<char, int>();
                //traversing through each element in the array
                for (int i = 0; i < arr.Length; i++)
                {
                    //following if condition performs two functions
                    /*1) if element is in the array and not in dictionary 
                    add that into dictionary with value being its position */

                    /*2) if element is in the dictionary already go to else function for duplicate value and check k
                     * where 
                        difference in position is calculated and stored in dictionary
                   */
                    if (!myDict.ContainsKey(arr[i]))
                    {
                        myDict.Add(arr[i], i);
                    }

                    else
                    {
                        // v takes the value of previous position of the identical key
                        int v = myDict[arr[i]];
                        // new_v is calculated as difference between current position and previous position 
                        int new_v = i - v;
                        //This new value is substituted in place of previous held key 
                        //and value marking the difference in the position
                        myDict[arr[i]] = new_v;

                        //check condition if the change in value is less than k.

                        if (myDict[arr[i]] <= k)
                        {
                            return true;
                        }


                    }


                }
                return false;







            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
