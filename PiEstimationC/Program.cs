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

            Console.Write("Number of Throws per Thread: ");
            holder = Console.ReadLine();
            throwsPer = int.Parse(holder);
            Console.Write("Number of Threads: ");
            holder = Console.ReadLine();
            threadsPer = int.Parse(holder);
            FindPiThread pi = new FindPiThread(throwsPer);
            int num = 0;
            for (int i = 0; i < threadsPer; i++)
            {
                pi.throwDarts();
                num += pi.getCount();
            }
            Console.Write(4 * num / (throwsPer * threadsPer +.0000000001)); 
                 //int i = 0;
                 List <FindPiThread> list = new List<FindPiThread>(threadsPer);
            List<Thread> threads = new List<Thread>(threadsPer);
            /*
            while (i < threadsPer)
            {
                
                FindPiThread piThread = new FindPiThread(throwsPer);
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
            Console.Write(4*totalNumInside/total);*/
            Console.ReadKey();
        }    }
}
