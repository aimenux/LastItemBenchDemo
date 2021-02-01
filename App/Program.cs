using BenchmarkDotNet.Running;

namespace App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var benchmarks = new[]
            {
                typeof(LastListItemBench),
                typeof(LastArrayItemBench)
            };

            var switcher = new BenchmarkSwitcher(benchmarks);
            switcher.Run(args);
        }
    }
}
