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

            List<FindPiThread> list = new List<FindPiThread>();
            List<Thread> threads = new List<Thread>();
            FindPiThread piThread = new FindPiThread(throwsPer * threadsPer);
            list.Append(piThread);
            threads.Append(new Thread(new ThreadStart(piThread.throwDarts)));
            threads[0].Start();
            Thread.Sleep(16);
                }
    }
}
