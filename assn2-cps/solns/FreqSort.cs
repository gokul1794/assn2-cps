using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace assn2_cps.solns
{
    class FreqSort
    {
        public static string FreqSortSoln(string s2)
        {
            List<string> sList = new List<string>();
            Dictionary<char, int> keyValue = new Dictionary<char, int>();
            string sortedString;
            try
            {
                s2 = s2.Replace(" ", string.Empty);
                if (s2.Length < 1)
                {
                    //Error note in case s2 is empty
                    sortedString = "Error: Ensure string \"s2\" contains characters.";
                }
                else
                {
                    for (int i = 0; i < s2.Length; i++)
                    {
                        if (keyValue.ContainsKey(s2[i]))
                        {
                            //increase value in keyValue dictionary by +1
                            keyValue[s2[i]] = ++keyValue[s2[i]];
                        }
                        else
                        {
                            //add char to dictionary initiating count of value with 1
                            keyValue.Add(s2[i], 1);
                        }
                    }
                    foreach (var item in keyValue.OrderByDescending(key => key.Value))
                    {
                        //multiply char by number of occurances(key.Value)
                        string temp = new string(item.Key, item.Value);
                        //add temp string to the list
                        sList.Add(temp);
                    }
                    sortedString = string.Join("", sList);
                }
            }
            catch (Exception e)
            {
                //Error info, in case of any errors
                sortedString = $"Error: {e.GetType().Name}";
            }
            return sortedString;
        }
    }
}
