using MultiThreading.Interfaces;

namespace MultiThreading.Implementations
{
    /// <summary>
    /// Implementation that summarizes the list elements in a plain sequence.
    /// </summary>
    public class PlainListSummarizer : IListSummarizer
    {
        /// <inheritdoc/>
        public long Summarize(IList<int> elements)
        {
            long sum = 0;

            foreach (int element in elements)
            {
                sum += element;
            }

            return sum;
        }
    }
}
