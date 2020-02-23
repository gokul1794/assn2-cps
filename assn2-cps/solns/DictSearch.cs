using System;
using System.Collections.Generic;
using System.Text;

namespace assn2_cps.solns
{
    class DictSearch
    {
        public static bool DictSearchSoln(string[] userDict, string keyword)
        {
            IDictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < userDict.Length; i++)
            {
                dict.Add(userDict[i], i);
            }
            if (dict.ContainsKey(keyword))
                return false;
            else
            {
                int count = 0;
                string correctWord = userDict[0];
                for (int i = 0; i < userDict.Length; i++)
                {
                    if (keyword.Length == userDict[i].Length)
                    {
                        string dictWord = userDict[i];
                        for (int j = 0; j < dictWord.Length; j++)
                        {
                            if (keyword[j] == dictWord[j])
                            {
                                count+=1;
                                correctWord = dictWord;
                            }
                        }
                        if (count == keyword.Length - 1)
                        {
                            Console.WriteLine(correctWord);
                            return true;
                        }
                        else
                        {
                            count = 0;
                        }
                    }
                }
            }
            return false;
        }
    }
}
