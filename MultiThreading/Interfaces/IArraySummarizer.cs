namespace MultiThreading.Interfaces
{
    /// <summary>
    /// Interface providing logic for summarizing the elements of an array.
    /// </summary>
    public interface IArraySummarizer
    {
        /// <summary>
        /// Calculates the sum of all the elements of the <paramref name="elements"/>.
        /// </summary>
        long Summarize(int[] elements);
    }
}
