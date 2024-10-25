using MultiThreading.Interfaces;

namespace MultiThreading.Implementations
{
    /// <summary>
    /// Implementation that summarizes the list elements in a custom parallelism.
    /// </summary>
    public class ParallelListSummarizer : IListSummarizer
    {
        /// <inheritdoc/>
        public long Summarize(IList<int> elements)
        {
            long sum = 0;

            Parallel.For<long>(
                fromInclusive: 0,
                toExclusive: elements.Count,
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
