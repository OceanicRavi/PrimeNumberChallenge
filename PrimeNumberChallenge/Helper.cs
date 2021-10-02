using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberChallenge
{
    /// <summary>
    /// Helper class is used to perform repeated operations.
    /// </summary>
    public class Helper 
    {
        /// <summary>
        /// This function returns list of prime numbers between 2 and maxValue
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static List<int> GetPrimeNumbersFromRange(int maxValue)
        {
 
            var r = from i in Enumerable.Range(2, maxValue - 1).AsParallel()
                    where Enumerable.Range(1, (int)Math.Sqrt(i)).All(j => j == 1 || i % j != 0)
                    select i;
            return r.ToList();
        }


        /// <summary>
        /// This function returns list of distinct subsets of size 2 from the list.
        /// </summary>
        /// <param name="listOfPrimeNumbers"></param>
        /// <returns></returns>
        public static List<Tuple<int, int>> GetSubset(List<int> listOfPrimeNumbers)
        {
            List<Tuple<int, int>> subset = new List<Tuple<int, int>>();
            for(int i=0;i<listOfPrimeNumbers.Count;i++)
            {
                for(int j=i+1;j<listOfPrimeNumbers.Count;j++)
                {
                    subset.Add(new Tuple<int, int>(listOfPrimeNumbers[i], listOfPrimeNumbers[j]));
                }
            }
            return subset;
        }

        /// <summary>
        /// This function returns True only if num1,num2,num3 and num4 are distinct else false.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <param name="num4"></param>
        /// <returns></returns>
        public static bool isDifferentNumbers(BigInteger num1, BigInteger num2, BigInteger num3, BigInteger num4)
        {
            if(num1==num2 || num1==num3 || num1 ==num4)
            {
                return false;
            }
            if (num2 == num3 || num2 == num4)
            {
                return false;
            }
            if (num3 == num4 )
            {
                return false;
            }
            return true;
        }
    }
}
