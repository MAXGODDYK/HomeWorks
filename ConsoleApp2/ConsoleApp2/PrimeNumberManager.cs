using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PrimeNumberManager
    {
        int[] _primeNumberList = new[] {2, 3, 5, 7, 11, 13, 17 };     
        public bool IsPrime(int n )
        {
            if (n < 17)
            { 
                //return Array.BinarySearch(_primeNumberList, n);
            }
            if (n <= 1)
                {
                    return false;
                }
            if (n == 2)
                {
                    return true;
                }
            if (n % 2 == 0)
                {
                    return false;
                }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
                {
                if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
        }
           
      
    }
}
