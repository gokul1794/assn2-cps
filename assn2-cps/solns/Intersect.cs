using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace assn2_cps.solns
{
    class Intersect
    {

        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            if (nums1.Length > nums2.Length)
            {
                return calculateWithSort(nums1, nums2);
            }
            else
            {
                return calculateWithSort(nums2, nums1);
            }
        }

        public static void DisplayArray(int[] intersect1)
        {
            if (intersect1.Length > 0)
            for(int i = 0; i < intersect1.Length; i++)
            {
                Console.Write(intersect1[i] + " ");
            }
            else
            {
                Console.WriteLine("No Intersections found!");
            }
        }

        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            
            if (nums1.Length > nums2.Length)
            {
                return calculateWithDictionary(nums1, nums2);
            }
            else
            {
                return calculateWithDictionary(nums2, nums1);
            }
        }
        /// <summary>
        /// Takes two integer arrays and returns an array with their intersection
        /// using sorting
        /// </summary>
        /// <param name="nums1">first int array</param>
        /// <param name="nums2">second int array</param>
        /// <returns>intersection array</returns>
        public static int[] calculateWithSort(int[] nums1, int[] nums2)
        {
            List<int> list = new List<int>();
            int left = 0, right = 0;
            int num1end = nums1.Length, num2end = nums2.Length;
            //Elements are traversed from the beginning of the array
            while (left < nums1.Length && right < nums2.Length)
            {
                //If numbers are matched, index is increased.
                if (nums1[left] == nums2[right])
                {
                    list.Add(nums1[left]);
                    left += 1;
                    right += 1;
                }
                else if (nums1[left] > nums2[right]) 
                    right++;    //If first array value greater than second array value then increase second array index
                else
                    left++;     //Else increase the left
            }
            return list.ToArray();

        }
        /// <summary>
        /// Takes two integer arrays and returns an array with their intersection 
        /// using a dictionary
        /// </summary>
        /// <param name="first">first int array</param>
        /// <param name="second">second int array</param>
        /// <returns>intersection array</returns>
        public static int[] calculateWithDictionary(int[] first, int[] second)
        {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < first.Length; i++)
            {
                if (dict.ContainsKey(first[i]))
                {
                    dict[first[i]] = ++dict[first[i]];  //If dictionary contains key, increment the occurence
                }
                else
                {
                    dict.Add(first[i], 1);  //New element, add 1 in the occurence
                }
            }
            List<int> list = new List<int>();
            //Adding keys to a list which have more than 1 occurence.
            for (int j = 0; j < second.Length; j++)
            {
                if (dict.ContainsKey(second[j]))
                {
                    if (dict[second[j]] > 0)
                    {
                        list.Add(second[j]);
                        dict[second[j]] = dict[second[j]] - 1;
                    }
                }
            }
            return list.ToArray();
        }
    }
}
