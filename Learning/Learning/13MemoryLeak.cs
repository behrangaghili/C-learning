using System;
using System.Collections.Generic;

namespace learning
{
    public class MemoryLeakExample
    {
        private static readonly List<byte[]> LeakedMemory = new List<byte[]>();

        // Method to demonstrate a memory leak caused by keeping references alive
        public static void DemonstrateMemoryLeak()
        {
            Console.WriteLine("Demonstrating a memory leak:");
            Console.WriteLine("This example keeps adding byte arrays to a static list.");
            Console.WriteLine("Because the list still references them, the garbage collector cannot free them.");

            for (int i = 1; i <= 5; i++)
            {
                byte[] data = new byte[1024 * 1024]; // Allocate 1 MB
                LeakedMemory.Add(data);

                Console.WriteLine("Iteration " + i + ": kept " + LeakedMemory.Count + " MB in memory.");
                Console.WriteLine("Total managed memory: " + GetManagedMemoryInMegabytes() + " MB");
            }

            Console.WriteLine("The memory stays alive because the static list still has references to the arrays.");
            Console.WriteLine(); // Add a blank line for clarity
        }

        // Method to demonstrate how releasing references lets memory be collected
        public static void FixMemoryLeak()
        {
            Console.WriteLine("Fixing the memory leak:");
            Console.WriteLine("Clearing the list removes the references to the byte arrays.");

            LeakedMemory.Clear();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            Console.WriteLine("After clearing references, total managed memory: " + GetManagedMemoryInMegabytes() + " MB");
            Console.WriteLine(); // Add a blank line for clarity
        }

        // Method to get current managed memory in megabytes
        private static long GetManagedMemoryInMegabytes()
        {
            return GC.GetTotalMemory(false) / (1024 * 1024);
        }
    }
}
