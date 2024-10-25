using System.Diagnostics;

namespace MultiThreading.Tests
{
    public static class ArraySummarizeTest
    {
        public static void RunTest(
            string functionName,
            Func<int[], long> function,
            int[] elements,
            int iterations)
        {
            ArgumentNullException.ThrowIfNull(function);

            if (iterations <= 0)
            {
                throw new ArgumentException("Iterations must be greater than zero.", nameof(iterations));
            }

            long result = default;
            List<long> executionTimesInTicks = [];

            for (int i = 0; i < iterations; i++)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                result = function(elements);
                stopwatch.Stop();

                executionTimesInTicks.Add(stopwatch.Elapsed.Ticks);
            }

            Console.WriteLine(
                "Function {0}:\n\tArray Length: {1}\n\tIterations: {2}\n\tResult: {3}\n\tAverage Time (ms): {4}\n",
                functionName,
                elements.Length,
                iterations,
                result,
                executionTimesInTicks.Average() / TimeSpan.TicksPerMillisecond);
        }
    }
}
