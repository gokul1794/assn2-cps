using System;
using System.Collections;
using System.Text;

namespace assn2_cps.solns
{
    class StringReverse
    {
        public static string StringReverseSoln(string s)
        {
            char[] reverse = s.ToCharArray();
            int left = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == ' ' || i == s.Length-1)
                {
                    int right;
                    if (i == s.Length - 1)
                        right = i;
                    else
                        right = i - 1;
                    while (left < right)
                    {
                        char temp = reverse[left];
                        reverse[left] = reverse[right];
                        reverse[right] = temp;
                        left++;
                        right--;
                    }
                    left = i + 1;
                }
            }
            return new string(reverse);
        }
    }
}
