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
            int i = 0;
            List<FindPiThread> list = new List<FindPiThread>(threadsPer);
            List<Thread> threads = new List<Thread>(threadsPer);
            while (i < threadsPer)
            {
                
                FindPiThread piThread = new FindPiThread(throwsPer * threadsPer);
                list.Append(piThread);
                threads.Append(new Thread(new ThreadStart(piThread.throwDarts)));
                threads[i].Start();
                Thread.Sleep(16);
                i++;
            }
            int j = 0;
            while (j < threadsPer)
            {
                threads[j].Join();
            }
            int k = 0;
            int totalNumInside = 0;
            int total = threadsPer * throwsPer;
            while(k < threadsPer)
            {
                totalNumInside += list[k].getCount();
            }
            Console.Write(4*totalNumInside/total);
        }    }
}
