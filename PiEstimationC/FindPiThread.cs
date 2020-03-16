using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiEstimationC
{
    class FindPiThread
    {
        int numDarts;
        int count;
        Random r;
        public FindPiThread(int num)
        {
            numDarts = num;
            count = 0;
            r = new Random();
        }
        public int getCount()
        {
            return count;
        }
        public void throwDarts()
        {
            for (int i = 0; i < numDarts; i++)
            {
                double x = r.NextDouble();
                double y = r.NextDouble();
                if (Math.Sqrt(x * x + y * y) <= 1)
                    { count = count + 1; }
            }
        }
    }
}
