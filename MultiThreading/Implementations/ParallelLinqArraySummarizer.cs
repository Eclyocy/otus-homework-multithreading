using MultiThreading.Interfaces;

namespace MultiThreading.Implementations
{
    /// <summary>
    /// Implementation that summarizes the array elements via the PLINQ.
    /// </summary>
    public class ParallelLinqArraySummarizer : IArraySummarizer
    {
        /// <inheritdoc/>
        public long Summarize(int[] elements)
        {
            return elements.AsParallel().Select(x => (long)x).Sum();
        }
    }
}
