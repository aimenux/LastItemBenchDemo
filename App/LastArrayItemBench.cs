using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace App
{
    [Config(typeof(BenchConfig))]
    [BenchmarkCategory(nameof(BenchCategory.Array))]
    public class LastArrayItemBench
    {
        private int[] _array;

        [Params(1000, 10000, 100000)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            _array = Enumerable.Range(0, Size)
                .Select(_ => random.Next())
                .ToArray();
        }

        [Benchmark]
        public int UsingLinq()
        {
            return _array.Last();
        }

        [Benchmark]
        public int UsingIndex()
        {
            var index = _array.Length - 1;
            return _array[index];
        }

        [Benchmark]
        public int UsingRange()
        {
            return _array[^1];
        }
    }
}
