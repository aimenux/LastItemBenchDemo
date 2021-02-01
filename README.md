![.NET 5](https://github.com/aimenux/LastItemBenchDemo/workflows/.NET%205/badge.svg)

# LastItemBenchDemo
```
Benchmarking various ways to get last item from collection (list, array)
```

In this demo, i m using [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) library in order to benchmark various ways of finding last item in a collection (list, array) :
>
> :one: Using linq
>
> :two: Using indexes
>
> :three: Using Ranges
>

In order to run benchmarks, type these commands in your favorite terminal :
>
> :writing_hand: `.\App.exe --filter LastListItemBench`
>
> :writing_hand: `.\App.exe --filter LastArrayItemBench`
>

```
|     Method |   Size |       Mean |     Error |    StdDev |        Min |        Max | Rank | Allocated |
|----------- |------- |-----------:|----------:|----------:|-----------:|-----------:|-----:|----------:|
| UsingRange |   1000 |  0.1868 ns | 0.0323 ns | 0.0302 ns |  0.1434 ns |  0.2393 ns |    1 |         - |
| UsingIndex |   1000 |  0.2807 ns | 0.0329 ns | 0.0308 ns |  0.2430 ns |  0.3423 ns |    2 |         - |
|  UsingLinq |   1000 | 22.9925 ns | 0.4925 ns | 0.5058 ns | 22.4384 ns | 24.1473 ns |    3 |         - |
|            |        |            |           |           |            |            |      |           |
| UsingRange |  10000 |  0.2131 ns | 0.0138 ns | 0.0129 ns |  0.1921 ns |  0.2282 ns |    1 |         - |
| UsingIndex |  10000 |  0.3064 ns | 0.0344 ns | 0.0460 ns |  0.2255 ns |  0.4187 ns |    2 |         - |
|  UsingLinq |  10000 | 23.5613 ns | 0.2234 ns | 0.2090 ns | 23.3008 ns | 23.9098 ns |    3 |         - |
|            |        |            |           |           |            |            |      |           |
| UsingIndex | 100000 |  0.1767 ns | 0.0127 ns | 0.0119 ns |  0.1504 ns |  0.1999 ns |    1 |         - |
| UsingRange | 100000 |  0.2450 ns | 0.0389 ns | 0.0382 ns |  0.2029 ns |  0.3349 ns |    2 |         - |
|  UsingLinq | 100000 | 22.9341 ns | 0.1171 ns | 0.0977 ns | 22.6640 ns | 23.0190 ns |    3 |         - |
```

**`Tools`** : vs19, net 5.0
