using MultiThreading.Interfaces;

namespace MultiThreading.Implementations
{
    /// <summary>
    /// Implementation that summarizes the list elements via the PLINQ.
    /// </summary>
    public class ParallelLinqListSummarizer : IListSummarizer
    {
        /// <inheritdoc/>
        public long Summarize(IList<int> elements)
        {
            return elements.AsParallel().Select(x => (long)x).Sum();
        }
    }
}
