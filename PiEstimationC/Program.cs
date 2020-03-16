using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PiEstimationC
{
    class Program
    {
        static void Main(string[] args)
        {
            int throwsPer;
            int threadsPer;
            string holder;
            
            Console.Write("Number of Throws per thread");
            holder = Console.ReadLine();
            throwsPer = int.Parse(holder);
            Console.Write("Number of Threads: ");
            holder = Console.ReadLine();
            threadsPer = int.Parse(holder);

            FindPiThread test = new FindPiThread(throwsPer*threadsPer);
            List<FindPiThread> h = new List<FindPiThread>();
            List<Thread> threads = new List<Thread>();


        }
    }
}
