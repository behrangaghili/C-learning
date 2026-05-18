using System;
using System.Threading;
using System.Threading.Tasks;

namespace learning
{
    public class ConcurrencyExample
    {
        private const int IncrementCount = 100000;
        private static readonly object CounterLock = new object();
        private static readonly SemaphoreSlim Semaphore = new SemaphoreSlim(1, 1);
        private static int counter;

        // Method to run all concurrency examples
        public static void DemonstrateConcurrency()
        {
            ExplainConcurrencyAndLocks();
            DemonstrateRaceCondition();
            DemonstrateLockFix();
            DemonstrateInterlockedAlternative();
            DemonstrateSemaphoreSlim();
            ExplainImportantConcepts();
        }

        private static void ExplainConcurrencyAndLocks()
        {
            Console.WriteLine("Demonstrating concurrency and thread locks:");
            Console.WriteLine("Concurrency means more than one task or thread can make progress during the same time period.");
            Console.WriteLine("A thread lock prevents multiple threads from running a critical section at the same time.");
            Console.WriteLine("Locks are mainly used to protect shared data from corruption.");
            Console.WriteLine();

            Console.WriteLine("Why counter++ is not automatically safe:");
            Console.WriteLine("1. Read counter");
            Console.WriteLine("2. Add 1");
            Console.WriteLine("3. Write counter");
            Console.WriteLine("If two threads read the same old value, one update can overwrite the other.");
            Console.WriteLine("That problem is called a race condition.");
            Console.WriteLine(); // Add a blank line for clarity
        }

        private static void DemonstrateRaceCondition()
        {
            counter = 0;

            Thread threadOne = new Thread(IncrementWithoutLock);
            Thread threadTwo = new Thread(IncrementWithoutLock);

            threadOne.Start();
            threadTwo.Start();

            // Join waits for the thread to finish before the program continues.
            threadOne.Join();
            threadTwo.Join();

            Console.WriteLine("Without lock:");
            Console.WriteLine("Expected counter: " + (IncrementCount * 2));
            Console.WriteLine("Actual counter: " + counter);
            Console.WriteLine("The actual value may be wrong because both threads modified shared data at the same time.");
            Console.WriteLine(); // Add a blank line for clarity
        }

        private static void IncrementWithoutLock()
        {
            for (int i = 0; i < IncrementCount; i++)
            {
                // This is a race condition because counter++ is read, add, and write.
                // Another thread can change counter between those steps.
                counter++;
            }
        }

        private static void DemonstrateLockFix()
        {
            counter = 0;

            Thread threadOne = new Thread(IncrementWithLock);
            Thread threadTwo = new Thread(IncrementWithLock);

            threadOne.Start();
            threadTwo.Start();

            threadOne.Join();
            threadTwo.Join();

            Console.WriteLine("With lock:");
            Console.WriteLine("Expected counter: " + (IncrementCount * 2));
            Console.WriteLine("Actual counter: " + counter);
            Console.WriteLine("The value is correct because only one thread enters the critical section at a time.");
            Console.WriteLine(); // Add a blank line for clarity
        }

        private static void IncrementWithLock()
        {
            for (int i = 0; i < IncrementCount; i++)
            {
                // The lock protects this critical section.
                // While one thread is inside, the other thread must wait.
                lock (CounterLock)
                {
                    counter++;
                }
            }
        }

        private static void DemonstrateInterlockedAlternative()
        {
            counter = 0;

            Thread threadOne = new Thread(IncrementWithInterlocked);
            Thread threadTwo = new Thread(IncrementWithInterlocked);

            threadOne.Start();
            threadTwo.Start();

            threadOne.Join();
            threadTwo.Join();

            Console.WriteLine("With Interlocked.Increment:");
            Console.WriteLine("Expected counter: " + (IncrementCount * 2));
            Console.WriteLine("Actual counter: " + counter);
            Console.WriteLine("Interlocked.Increment is an atomic operation, so it is a fast alternative for simple counters.");
            Console.WriteLine(); // Add a blank line for clarity
        }

        private static void IncrementWithInterlocked()
        {
            for (int i = 0; i < IncrementCount; i++)
            {
                // Atomic means the increment happens as one indivisible operation.
                Interlocked.Increment(ref counter);
            }
        }

        private static void DemonstrateSemaphoreSlim()
        {
            Console.WriteLine("With SemaphoreSlim:");
            Console.WriteLine("SemaphoreSlim is useful when async code needs controlled access to a shared resource.");
            Console.WriteLine("new SemaphoreSlim(1, 1) means minimum one available slot and maximum one slot.");
            Console.WriteLine("Because the maximum is one, only one async operation can enter at a time.");

            Task workerOne = UseSharedResourceAsync("Async worker 1");
            Task workerTwo = UseSharedResourceAsync("Async worker 2");
            Task workerThree = UseSharedResourceAsync("Async worker 3");

            Task.WaitAll(workerOne, workerTwo, workerThree);

            Console.WriteLine("All async workers finished using the shared resource one at a time.");
            Console.WriteLine(); // Add a blank line for clarity
        }

        private static async Task UseSharedResourceAsync(string workerName)
        {
            Console.WriteLine(workerName + " is waiting for the semaphore.");

            // WaitAsync does not block the current thread while waiting.
            // This is why SemaphoreSlim is commonly used with async code instead of lock.
            await Semaphore.WaitAsync();

            try
            {
                Console.WriteLine(workerName + " entered the async critical section.");

                // This simulates async work, such as a database call or web API call.
                // You cannot await inside a lock block, but you can await after WaitAsync.
                await Task.Delay(500);

                Console.WriteLine(workerName + " is leaving the async critical section.");
            }
            finally
            {
                // Release must be in finally so the semaphore is released even if an error happens.
                Semaphore.Release();
            }
        }

        private static void ExplainImportantConcepts()
        {
            Console.WriteLine("Important concurrency concepts:");
            Console.WriteLine("1. Critical section: code that must not run at the same time on multiple threads.");
            Console.WriteLine("2. Deadlock: threads wait forever because each thread holds a lock the other one needs.");
            Console.WriteLine("3. Lock contention: too many threads wait for the same lock, which can hurt performance.");
            Console.WriteLine("4. Do not lock this. Use a private object like private readonly object _lock = new object();");
            Console.WriteLine("5. You cannot use await inside lock. For async code, use SemaphoreSlim instead.");
            Console.WriteLine();

            Console.WriteLine("Common synchronization tools:");
            Console.WriteLine("lock: basic thread synchronization.");
            Console.WriteLine("Monitor: advanced lock control.");
            Console.WriteLine("Mutex: cross-process locking.");
            Console.WriteLine("SemaphoreSlim: async-friendly concurrency control.");
            Console.WriteLine("ReaderWriterLockSlim: many readers and few writers.");
            Console.WriteLine("Interlocked: atomic operations.");
            Console.WriteLine("ConcurrentDictionary: thread-safe key-value collection.");
            Console.WriteLine();

            Console.WriteLine("Simple mental model:");
            Console.WriteLine("Think of lock like a key. One thread takes the key and enters. Other threads wait.");
            Console.WriteLine("When the key is returned, the next thread can enter.");
            Console.WriteLine(); // Add a blank line for clarity
        }
    }
}
