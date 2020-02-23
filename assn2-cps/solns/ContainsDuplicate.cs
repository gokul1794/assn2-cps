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

                for (int i = 0; i < arr.Length; i++)
                {
                    if (!myDict.ContainsKey(arr[i]))
                    {
                        myDict.Add(arr[i], i);
                    }

                    else
                    {
                        int v = myDict[arr[i]];
                        int new_v = i - v;
                        myDict[arr[i]] = new_v;
                        Console.WriteLine(myDict[arr[i]]);
                        if (myDict[arr[i]] <= k)
                        {
                            return true;
                        }


                    }


                }
                return false;
                //foreach (KeyValuePair<char, int> kvp in myDict)
                // {
                //     Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                //}






            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
