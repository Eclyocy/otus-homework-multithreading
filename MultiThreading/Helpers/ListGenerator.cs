namespace MultiThreading.Helpers
{
    /// <summary>
    /// Helper for generating lists.
    /// </summary>
    internal static class ListGenerator
    {
        /// <summary>
        /// Generates a list of integers of a given length.
        /// </summary>
        public static List<int> GenerateList(int elementsLength)
        {
            Random random = new();

            return Enumerable
                .Range(0, elementsLength)
                .Select(_ => random.Next())
                .ToList();
        }
    }
}
