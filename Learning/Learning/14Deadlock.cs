using System;
using System.Threading;
using System.Threading.Tasks;

namespace learning
{
    public class DeadlockExample
    {
        private static readonly object FirstLock = new object();
        private static readonly object SecondLock = new object();
        private static readonly object SafeFirstLock = new object();
        private static readonly object SafeSecondLock = new object();
        

        // Method to explain and safely demonstrate the deadlock concept
        public static void DemonstrateDeadlock()
        {
            Console.WriteLine("Demonstrating a deadlock:");
            Console.WriteLine("A deadlock happens when two or more threads wait for each other forever.");
            Console.WriteLine("In this example, Thread 1 locks FirstLock and waits for SecondLock.");
            Console.WriteLine("At the same time, Thread 2 locks SecondLock and waits for FirstLock.");
            Console.WriteLine("Neither thread can continue because each thread is holding the lock the other thread needs.");

            Task threadOne = Task.Run(ThreadOneWork);
            Task threadTwo = Task.Run(ThreadTwoWork);
            Console.WriteLine("Thread one status: " + threadOne.Status);
            Console.WriteLine("Thread two status: " + threadTwo.Status);
            // We use a timeout so this lesson does not freeze the whole program forever.
            // In a real deadlock, WaitAll without a timeout would never finish.
            bool finished = Task.WaitAll(new[] { threadOne, threadTwo }, 10000);
            Console.WriteLine("Thread one status: " + threadOne.Status);
            Console.WriteLine("Thread two status: " + threadTwo.Status);
            if (!finished)
            {
                Console.WriteLine("Deadlock detected: the tasks did not finish within the timeout.");
                Console.WriteLine("This means each task is waiting for a lock that the other task is holding.");
            }

            Console.WriteLine(); // Add a blank line for clarity
        }

        // Method to show the correct way to avoid this type of deadlock
        public static void DemonstrateDeadlockPrevention()
        {
            Console.WriteLine("Preventing a deadlock:");
            Console.WriteLine("A common fix is to always take locks in the same order.");
            Console.WriteLine("Both tasks below lock SafeFirstLock first, then SafeSecondLock.");

            Task threadOne = Task.Run(SafeThreadWork);
            Task threadTwo = Task.Run(SafeThreadWork);
            Console.WriteLine("Thread one status: " + threadOne.Status);
            Console.WriteLine("Thread two status: " + threadTwo.Status);

             Task.WaitAll(threadOne, threadTwo);
            Console.WriteLine("Thread one status: " + threadOne.Status);
            Console.WriteLine("Thread two status: " + threadTwo.Status);

            Console.WriteLine("Both tasks finished because they asked for the locks in the same order.");
            Console.WriteLine(); // Add a blank line for clarity
        }

        private static void ThreadOneWork()
        {
            lock (FirstLock)
            {
                Console.WriteLine("Thread 1 locked FirstLock.");

                // Sleep gives Thread 2 time to lock SecondLock.
                // This makes the deadlock easier to reproduce for the lesson.
                Thread.Sleep(10000);

                Console.WriteLine("Thread 1 is waiting for SecondLock.");
                lock (SecondLock)
                {
                    Console.WriteLine("Thread 1 locked SecondLock.");
                }
            }
        }

        private static void ThreadTwoWork()
        {
            lock (SecondLock)
            {
                Console.WriteLine("Thread 2 locked SecondLock.");

                // Sleep gives Thread 1 time to lock FirstLock.
                // Now both threads own one lock and wait for the other lock.
                Thread.Sleep(10000);

                Console.WriteLine("Thread 2 is waiting for FirstLock.");
                lock (FirstLock)
                {
                    Console.WriteLine("Thread 2 locked FirstLock.");
                }
            }
        }

        private static void SafeThreadWork()
        {
            // Both tasks take locks in the same order.
            // If every thread follows one lock order, circular waiting cannot happen here.
            // These are separate locks because the previous example intentionally leaves
            // two tasks deadlocked while holding FirstLock and SecondLock.
            lock (SafeFirstLock)
            {
                Console.WriteLine("Safe task locked SafeFirstLock.");
                Thread.Sleep(10000);

                lock (SafeSecondLock)
                {
                    Console.WriteLine("Safe task locked SafeSecondLock.");
                }
            }
        }
    }
}
