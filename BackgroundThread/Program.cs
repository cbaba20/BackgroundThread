using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundThread
{
    public static class Program
    {
        //this program is shows background thread. If IsBackground set to true then this application exits immediately.
        //If IsBackground set to flase then this application prints "ThreadPRoc" 10 times. 
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadPRoc: {0}", i);
                Thread.Sleep(1000);
            }
        }
        public static void Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = false;
            t.Start();
        }
    }
}
