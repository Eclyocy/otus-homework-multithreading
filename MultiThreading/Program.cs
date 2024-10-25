using MultiThreading.Helpers;
using MultiThreading.Implementations;
using MultiThreading.Interfaces;
using MultiThreading.Tests;

namespace MultiThreading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] elementsLengths = [100, 1000, 10000, 100000, 1000000, 10000000, 100000000, 1000000000];

            IArraySummarizer[] arraySummarizers =
            [
                new PlainArraySummarizer(),
                new ParallelArraySummarizer(),
                new ParallelLinqArraySummarizer()
            ];

            foreach (int elementsLength in elementsLengths)
            {
                int[] elements = ArrayGenerator.GenerateArray(elementsLength);

                foreach (IArraySummarizer arraySummarizer in arraySummarizers)
                {
                    ArraySummarizeTest.RunTest(
                        arraySummarizer.GetType().Name,
                        arraySummarizer.Summarize,
                        elements,
                        100);
                }
            }
        }
    }
}
