using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Buffer_Example
{
     class Program
    {
        static Stack<string> Buffer = new Stack<string>();
        static Semaphore full = new Semaphore(0,10);
        static Semaphore empty= new Semaphore(10,10);
        static Semaphore Mutex = new Semaphore(1,1); // عشان اشغل اكتر من بروديوسر مع بعض
        static void Main(string[] args)
        {
            Thread producer = new Thread(produce);
            producer.Start();
            Thread consumer  = new Thread(consume);
            consumer.Start();



            Console.ReadKey();
        }
        static void produce()
        {
            for (int i = 0; i < 10; i++)
            {
                empty.WaitOne(); // decrement empty places
                Mutex.WaitOne();
                Buffer.Push("item" + i);
                Console.WriteLine("item {0} is produced ",i);
                Thread.Sleep(100);
                Mutex.Release();
                full.Release(); // increment full places

            }
        }
        static void consume()
        {
            for (int i = 0; i < 10; i++)
            {
                full.WaitOne(); // decrement full places
                Mutex.WaitOne();
                Buffer.Pop();
                Console.WriteLine("item {0} is Consumed ",i);
                Thread.Sleep(100);
                Mutex.Release();
                empty.Release(); // increment empty places
            }
        }
    }
}
