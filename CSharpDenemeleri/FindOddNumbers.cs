using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDenemeleri
{
    class FindOddNumbers
    {
        public int findOddNumbers(int p1)
        {
            int sum = 0, i = 1;
            while (i <= p1)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    Console.Write("{0} ", i);
                }
                i++;
            }
            return sum;
        }
    }
}
