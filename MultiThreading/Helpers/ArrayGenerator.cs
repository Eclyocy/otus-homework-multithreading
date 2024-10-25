namespace MultiThreading.Helpers
{
    /// <summary>
    /// Helper for generating array data.
    /// </summary>
    internal static class ArrayGenerator
    {
        /// <summary>
        /// Generates an array of integers of a given length.
        /// </summary>
        public static int[] GenerateArray(int elementsLength)
        {
            Random random = new();

            return Enumerable
                .Range(0, elementsLength)
                .Select(_ => random.Next())
                .ToArray();
        }
    }
}
