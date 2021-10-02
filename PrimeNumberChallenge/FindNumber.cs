using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PrimeNumberChallenge
{
    /// <summary>
    /// FindNumber class will be used to find four prime numbers fulfilling the criteria.
    /// </summary>
    public class FindNumber:IFindNumber
    {
        public List<int> ListOfPrimeNumbers;

        /// <summary>
        /// Function will generate list of prime numbers under the range of 1000 and find four prime numbers passing the criteria.
        /// </summary>
        /// <returns></returns>
        public List<int> GetFourPrimeNumbers()
        {
            Console.WriteLine("Getting Prime numbers between 0 to 1000");
            ListOfPrimeNumbers = Helper.GetPrimeNumbersFromRange(1000);           
            int[] result = GetFourNumbers(ListOfPrimeNumbers);
            return result.ToList();
        }
        /// <summary>
        /// Function to check the criteria: 
        /// 1. The digits of the number 'Value' are either sequential or same as previous digit.
        /// 2. The 'Value' must be a 12 digit number.
        /// Function returns True if the criteria is satisfied else False.
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public bool CheckProductCriteria(BigInteger Value)
        {
            //Function will proceed for Value greater than 11 digits.
            if (Value.ToString().Length < 12)
                {
                    return false;
                }
            char[] temp = Value.ToString().ToCharArray();
            int[] foo = new int[temp.Count()];
            for (int i = 0; i < temp.Count(); i++)
            {
                foo[i] = Convert.ToInt32(temp[i]);
                if ((i > 0) && (foo[i] != foo[i - 1] && foo[i] != foo[i - 1] + 1))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Function will find four unique prime numbers from the list such that their product satisfy the CheckProductCriteria.
        /// First the function will generate all possible subsets of size 4 from the list.
        /// Then function performs multiplication of each elements of subset given that subset contains distinct elements.
        /// The obtained product is checked by the CheckProductCriteria.
        /// Any subset passing the check criteria will be returned.
        /// </summary>
        /// <param name="listOfPrimeNumbers"></param>
        /// <returns></returns>
        public int[] GetFourNumbers(List<int> listOfPrimeNumbers)
        {
            try
            {
                int[] numbers = new int[4];
                List<Tuple<int, int>> subset = Helper.GetSubset(listOfPrimeNumbers);
                Console.WriteLine("Finding four prime numbers that satisfy the criteria: ");
                foreach (var sub1 in subset)
                {
                    foreach (var sub2 in subset)
                    {
                        BigInteger num1 = sub1.Item1, num2 = sub1.Item2, num3 = sub2.Item1, num4 = sub2.Item2;
                        if (Helper.isDifferentNumbers(num1, num2, num3, num4))
                        {
                            BigInteger product = num1 * num2 * num3 * num4;
                            if (CheckProductCriteria(product))
                            {
                                numbers[0] = (int)num1;
                                numbers[1] = (int)num2;
                                numbers[2] = (int)num3;
                                numbers[3] = (int)num4;
                                break;
                            }
                        }
                    }
                }
                return numbers;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
           
        }
    }
}
