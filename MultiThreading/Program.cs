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
            List<int> _elementsLengths = [100, 1000, 10000, 100000, 1000000, 10000000];

            List<IListSummarizer> _listSummarizers =
            [
                new PlainListSummarizer(),
                new ParallelListSummarizer(),
                new ParallelLinqListSummarizer()
            ];

            foreach (int elementsLength in _elementsLengths)
            {
                IList<int> elements = ListGenerator.GenerateList(elementsLength);

                foreach (IListSummarizer listSummarizer in _listSummarizers)
                {
                    ListSummarizeTest.RunTest(
                        listSummarizer.GetType().Name,
                        listSummarizer.Summarize,
                        elements,
                        100);
                }
            }
        }
    }
}
