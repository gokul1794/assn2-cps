using System;
using System.Collections;
using System.Text;

namespace assn2_cps.solns
{
    class StringReverse
    {
        /// <summary>
        /// Reverses a string at the same index
        /// </summary>
        /// <param name="s">String to be reversed</param>
        /// <returns>Reversed string</returns>
        public static string StringReverseSoln(string s)
        {
            char[] reverse = s.ToCharArray();
            try
            {
                int left = 0;
                //Iterate through the length of the string
                for (int i = 0; i < s.Length; i++)
                {
                    //If you encounter a space or the last word
                    if (s[i] == ' ' || i == s.Length - 1)
                    {
                        int right;
                        if (i == s.Length - 1)
                            right = i;
                        else
                            right = i - 1;
                        //swap the left most letter of the word with right most
                        //Move left index right and right index left
                        while (left < right)
                        {
                            char temp = reverse[left];
                            reverse[left] = reverse[right];
                            reverse[right] = temp;
                            left++;
                            right--;
                        }
                        left = i + 1; //index of left is the letter after space.
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return new string(reverse);
        }
    }
}
