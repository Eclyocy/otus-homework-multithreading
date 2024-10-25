namespace MultiThreading.Interfaces
{
    /// <summary>
    /// Interface providing logic for summarizing the elements of a list.
    /// </summary>
    public interface IListSummarizer
    {
        /// <summary>
        /// Calculates the sum of all the elements of the <paramref name="elements"/>.
        /// </summary>
        long Summarize(IList<int> elements);
    }
}
