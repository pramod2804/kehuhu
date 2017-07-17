using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ConstructRectangle
    {
        public int[] ConstructRectangleLW(int area)
        {

            double sqrt = Math.Sqrt(area);
            int intSqrt = (int)sqrt;
            if (sqrt == intSqrt) return new int[] { intSqrt, intSqrt };
            
            for (int i = intSqrt + 1; i <= area; i++)
            {
                if (area % i == 0) return new int[] { i, area / i };
            }
            return null;
        }
    }
}
