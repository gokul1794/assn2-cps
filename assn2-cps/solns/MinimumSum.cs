using System;
using System.Collections.Generic;
using System.Text;

namespace assn2_cps.solns
{
    class MinimumSum
    {
        public static int MinimumSumSoln(int[] l2)
        {



            try
            {
                if (l2.Length == 0)
                {
                    Console.WriteLine("There are no elements in the array");
                    return 0;
                }
                else
                {
                    //Initiated the sum with first value as the array 0th position
                    int sum = l2[0];
                    int i;
                    //Traversing i till end of l2 array -1 
                    for (i = 0; i < l2.Length - 1; i++)
                    {   /*//
                    This condition compares the number ahead with number before in the array
                    if it finds duplicate numbers it adds the number which is ahead by 1.
                    */
                        if (l2[i + 1] == l2[i])
                        {
                            l2[i + 1] = l2[i] + 1;

                            /*//if there are multiple duplicates in range eg. 2,2,2,2
                            then it would only change the next digit. All other digit will still remain the same
                             violating question's condition of being a sorted array.*/
                            // eg.(2,2,2,2) -> 2,3,2,2

                            //code below solves such a problem

                            // traverses till there can not be anymore violation of sorting 
                            if (i < l2.Length - 2)
                            {
                                //for repetative duplicates like (2,2,2....). 
                                //Since now the previous element has changed for eg.(2,2,2..)->(2,3,2).
                                /*//so in this case 
                                 * we change the element after changed number, by the absolute difference of changed number
                                 * and number after that*/
                                if (l2[i + 2] < l2[i + 1])
                                {
                                    int c = l2[i + 1] - l2[i + 2];
                                    //adding the difference to the number after that
                                    //i.e eg(2,3,2) -> (2,3,3) 
                                    l2[i + 2] = c + l2[i + 2];
                                    // so now in the other iteration from now, our condition to check duplicates won't fail
                                }
                            }
                        }
                        //iteratively generating the sum
                        sum = sum + l2[i + 1];

                    }
                    Console.WriteLine("transformed array if duplicates were found: ");
                    for (int j = 0; j < l2.Length; j++)
                    {
                        Console.Write(l2[j] + ", ");
                    }
                    return sum;
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

    }
}
