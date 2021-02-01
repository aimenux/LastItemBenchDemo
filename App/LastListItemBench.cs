using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace App
{
    [Config(typeof(BenchConfig))]
    [BenchmarkCategory(nameof(BenchCategory.List))]
    public class LastListItemBench
    {
        private List<int> _list;

        [Params(1000, 10000, 100000)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            _list = Enumerable.Range(0, Size)
                .Select(_ => random.Next())
                .ToList();
        }

        [Benchmark]
        public int UsingLinq()
        {
            return _list.Last();
        }

        [Benchmark]
        public int UsingIndex()
        {
            var index = _list.Count - 1;
            return _list[index];
        }

        [Benchmark]
        public int UsingRange()
        {
            return _list[^1];
        }
    }
}
