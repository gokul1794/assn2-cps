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
            for (int i = 0; i < s2.Length; i++)
            {
                if (keyValue.ContainsKey(s2[i]))
                {
                    keyValue[s2[i]] = ++keyValue[s2[i]];
                }
                else
                {
                    keyValue.Add(s2[i], 1);
                }
            }
            foreach (var item in keyValue.OrderByDescending(key => key.Value))
            {
                string temp = new string(item.Key, item.Value);
                sList.Add(temp);
            }
            string sortedString = string.Join("", sList);
            return sortedString;
        }
    }
}
