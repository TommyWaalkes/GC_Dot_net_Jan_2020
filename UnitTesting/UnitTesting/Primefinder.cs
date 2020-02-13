using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    class Primefinder
    {
        public string GetOddEvenPrime(int num)
        {
            if(num == 2)
            {
                return "prime";
            }
            if(num % 2 == 0)
            {
                return "even";
            }
            else
            {
                for(int i = num -1; i > 1; i--)
                {
                    if(num % i == 0)
                    {
                        return "odd";
                    }
                }
                return "prime";
            }
            
        }
    }
}
