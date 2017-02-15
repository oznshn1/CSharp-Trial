using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDenemeleri
{
    class Factorial
    {
        public int CalculateFactorial(int p1)
        {
            int sum = 1;
            while (p1 >= 1)
            {
                sum *= p1;
                p1--;
            }
            return sum;
        }
        public int factorial_recursive(int p1)
        {
            if (p1 > 0)
                return p1*factorial_recursive(p1 - 1);

            return 1;
        }
    }
}
