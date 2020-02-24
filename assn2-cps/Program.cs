using System;
using System.Diagnostics;
using assn2_cps.solns;

namespace assn2_cps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            int target = 9;
            int[] r = TargetRange.TargetRangeSoln(l1, target);
            // Write your code to print range r here 
            Console.WriteLine("[" + r[0] + "," + r[1] + "]");

            Console.WriteLine("Question 2");
            String s = "University of South Florida";
            String rs = StringReverse.StringReverseSoln(s);
            Console.WriteLine(rs);

            Console.WriteLine("Question 3");
            int[] l2 = new int[] { 2, 2, 2, 4, 5, 7 };
            int sum = MinimumSum.MinimumSumSoln(l2);
            Console.WriteLine("The Sum is:  " + sum);

            Console.WriteLine("Question 4");
            string s2 = "Dell";
            string sortedString = FreqSort.FreqSortSoln(s2);
            Console.WriteLine(sortedString);

            Console.WriteLine("Question 5-Part 1");
            int[] nums1 = { 1, 1, 2, 2, 2 };
            int[] nums2 = { 2, 2 };
            try
            {
                int[] intersect1 = Intersect.Intersect1(nums1, nums2);
                Console.WriteLine("Part 1- Intersection of two arrays is: ");
                Intersect.DisplayArray(intersect1); Console.WriteLine("\n");
                Console.WriteLine("Question 5-Part 2");
                int[] intersect2 = Intersect.Intersect2(nums1, nums2);
                Console.WriteLine("Part 2- Intersection of two arrays is: ");
                Intersect.DisplayArray(intersect2);
                Console.WriteLine("\n");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            int k = 3; Console.WriteLine(ContainsDuplicate.ContainsDuplicateSoln(arr, k));

            Console.WriteLine("Question 7");
            int rodLength = 15;
            int priceProduct = GoldRod.GoldRodSoln(rodLength);
            Console.WriteLine(priceProduct);

            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "hhllo";
            try
            {
                if (userDict.Length > 0)
                    Console.WriteLine(DictSearch.DictSearchSoln(userDict, keyword));
                else
                    Console.WriteLine("Enter an array with at least one element.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Question 9");
            Console.WriteLine(" ");
            try
            {
                SolvePuzzle.SolvePuzzleSoln();
            }catch(Exception e)
            {
                Debug.WriteLine(e.StackTrace);
                Console.WriteLine("Error computing the solution.");
            }

        }
    }
}
