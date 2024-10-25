using MultiThreading.Interfaces;

namespace MultiThreading.Implementations
{
    /// <summary>
    /// Implementation that summarizes the array elements in a plain sequence.
    /// </summary>
    public class PlainArraySummarizer : IArraySummarizer
    {
        /// <inheritdoc/>
        public long Summarize(int[] elements)
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
