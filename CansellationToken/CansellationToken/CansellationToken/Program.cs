using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Create a cancellation token source
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        // Get the cancellation token from the source
        CancellationToken cancellationToken = cancellationTokenSource.Token;

        Console.WriteLine("Press 'b' and Enter to cancel...");

        Task task = Task.Run(async () =>
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    Task task1 = PerformOperationAsync("Task 1", 3000, cancellationToken);
                    Task task2 = PerformOperationAsync("Task 2", 5000, cancellationToken);

                    // Await all tasks, observing cancellation
                    await Task.WhenAll(task1, task2);
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation was canceled.");
            }
        });

        // Wait for user to press 'b' and Enter to cancel
        while (true)
        {
            var keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == 'b')
            {
                // Signal the cancellation
                cancellationTokenSource.Cancel();
                break; // Exit the loop
            }
        }

        // Wait for the task to complete
        await task;
    }

    static async Task PerformOperationAsync(string taskName, int delayMilliseconds, CancellationToken cancellationToken)
    {
        try
        {
            await Task.Delay(delayMilliseconds, cancellationToken);
            Console.WriteLine($"{taskName} completed.");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine($"{taskName} was canceled.");
            throw; // Re-throw the exception to preserve cancellation behavior
        }
    }
}
