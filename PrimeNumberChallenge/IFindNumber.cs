using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberChallenge
{
    interface IFindNumber
    {
        bool CheckProductCriteria(BigInteger maxValue);
        int[] GetFourNumbers(List<int> listOfPrimeNumbers);
    }
}
