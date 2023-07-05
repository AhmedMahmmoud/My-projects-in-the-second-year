using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Deadlock
{
     class Program
    {
        static int tickets = 10; //shared variable
        //static object objloc= new object(); // shared object using lock
        // static Mutex M = new Mutex(); //shared object using Mutex
        //static object objloc= new object(); // shared object using monitor
        static Semaphore s = new Semaphore(1,1);   // binary semaphpre
        static void Main(string[] args)
        {
            Thread solution1 = new Thread (reserve);
            Thread solution2 = new Thread (reserve);
            solution1.Name = "station 1";
            solution2.Name = "station 2";
            solution1.Start ();
            solution2.Start ();
            Console.ReadKey();
        }
        static void reserve()
        {
            while (tickets>0) 
            {
                s.WaitOne(); // 1-1=0
                
                    if (tickets > 0)
                    {
                        tickets--;
                        Console.WriteLine(Thread.CurrentThread.Name + " tickets num {0}", tickets);
                        Thread.Sleep(300);
                    }

                s.Release(); //0+1 =1
            }

        }
    }
}
