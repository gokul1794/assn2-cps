using System;
using System.Collections.Generic;
using System.Text;

namespace assn2_cps.solns
{
    class DictSearch
    {
        /// <summary>
        /// Looks for a word in the dictionary and returns the word if the charachter is off by 1
        /// </summary>
        /// <param name="userDict">Dictionary of words</param>
        /// <param name="keyword">Keyword to be checked</param>
        /// <returns>True/False</returns>
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
                    //Check all words with the same length
                    if (keyword.Length == userDict[i].Length)
                    {
                        string dictWord = userDict[i];
                        for (int j = 0; j < dictWord.Length; j++)
                        {
                            //Compare word and keyword char and increase count of same chars
                            if (keyword[j] == dictWord[j])
                            {
                                count+=1;
                                correctWord = dictWord;
                            }
                        }
                        //If word lengths match and if keyword is length -1 then word is found.
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
