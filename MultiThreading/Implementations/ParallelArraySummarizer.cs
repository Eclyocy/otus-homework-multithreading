using MultiThreading.Interfaces;

namespace MultiThreading.Implementations
{
    /// <summary>
    /// Implementation that summarizes the array elements in a custom parallelism.
    /// </summary>
    public class ParallelArraySummarizer : IArraySummarizer
    {
        /// <inheritdoc/>
        public long Summarize(int[] elements)
        {
            long sum = 0;

            Parallel.For<long>(
                fromInclusive: 0,
                toExclusive: elements.Length,
                localInit: () => 0,
                body: (i, loop, subSum) =>
                {
                    subSum += elements[i];
                    return subSum;
                },
                localFinally: subSum => Interlocked.Add(ref sum, subSum));

            return sum;
        }
    }
}
