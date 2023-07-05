using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace task_5
{
    internal class Program
    {
        static int numPhilosophers = 5;
        static int numForks = 5;
        static Semaphore[] forks = new Semaphore[numForks];
        static Semaphore maxPhilosophers = new Semaphore(numPhilosophers / 2, numPhilosophers / 2);
        static void Main(string[] args)
        {
            for (int i = 0; i < numForks; i++)
            {
                forks[i] = new Semaphore(1, 1);
            }

            Thread[] philosophers = new Thread[numPhilosophers];
            for (int i = 0; i < numPhilosophers; i++)
            {
                philosophers[i] = new Thread(new ParameterizedThreadStart(Philosopher));
                philosophers[i].Start(i);
            }

            Console.ReadLine();
        }

        static void Philosopher(object obj)
        {
            int philosopherId = (int)obj;

            while (true)
            {
                // Wait until there are less than 4 philosophers on the table
                maxPhilosophers.WaitOne();

                int fork1Index, fork2Index;
                if (philosopherId % 2 == 0)
                {
                    fork1Index = philosopherId;
                    fork2Index = (philosopherId + 1) % numForks;
                }
                else
                {
                    fork1Index = (philosopherId + 1) % numForks;
                    fork2Index = philosopherId;
                }

                // Wait until both forks are available
                forks[fork1Index].WaitOne();
                forks[fork2Index].WaitOne();

                Console.WriteLine("Philosopher {0} is eating", philosopherId);
                Thread.Sleep(1000);

                // Release both forks
                forks[fork1Index].Release();
                forks[fork2Index].Release();

                // Signal that there's one less philosopher on the table
                maxPhilosophers.Release();
                Console.WriteLine("Philosopher {0} is thinking", philosopherId);
                Thread.Sleep(1000);
            }
        }
    }
}
