using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_fac_fib.Classes
{
    public class Factorial
    {
        int num = 0;
        public Factorial(int _num)
        {
            num = _num;
        }

        public int fact()
        {
            int i, factorial = 1;
            for (i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
                return factorial;
        }
          
       
    }
}

