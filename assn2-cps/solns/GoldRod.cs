using System;
using System.Collections.Generic;
using System.Text;

namespace assn2_cps.solns
{
    class GoldRod
    {
        public static int GoldRodSoln(int rodLength)
        {
            int price;
            if (rodLength < 4) //if Rocky is given a rod with less than 4 intergers in length, the rod should not be cut to maximize price, so the price=rodLenght
            {
                price = rodLength;
            }
            else { 
                //initialize array of product values that will track max price depending on rod length
                int[] maxValues = new int[rodLength+1];
                maxValues[0] = 0;
                maxValues[1] = 0;
                maxValues[2] = 1;
                maxValues[3] = 2;
                for (int i =4;i<=rodLength; i++)
                {
                    int greatestValue = -1;
                    for (int j = 2; j <= (i / 2); j++)
                    {
                        //possible factors depending on rod length
                        int factor1 = j;
                        int factor2 = i - j;

                        //determine if rod should be divided further depending on stored product price in maxValues array
                        int maxProduct1 = maxValues[factor1] > factor1 ? maxValues[factor1] : factor1;
                        int maxProduct2 = maxValues[factor2] > factor2 ? maxValues[factor2] : factor2;
                        //product between factors
                        int factorProduct = maxProduct1 * maxProduct2;
                        if (factorProduct > greatestValue)
                        {
                            greatestValue = factorProduct;
                        }
                    }
                    //add greatest product value to tracker
                    maxValues[i] = greatestValue;
                }
                price = maxValues[rodLength];
            }
            return price;
        }
    }
}
