using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberChallenge
{
    /// <summary>
    /// Author: ravi bhatt
    /// PrimeNumberChallenge console application will return four different prime numbers whose product have sequential digits or same as previous digit.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Printing four prime numbers satisfying the critera---");
            DateTime dt1 = DateTime.Now;
            FindNumber findNum = new FindNumber();
            List<int> result = findNum.GetFourPrimeNumbers();
            foreach(int num in result)
            {
                Console.WriteLine(num);
            }
            TimeSpan tp = DateTime.Now - dt1;
            Console.WriteLine("Time taken in minutes: " + tp.TotalMinutes);
            Console.ReadLine();
        }
    }
}
