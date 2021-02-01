![.NET](https://github.com/aimenux/LastItemBenchDemo/workflows/.NET/badge.svg)

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
|     Method |   Size |       Mean |     Error |    StdDev |     Median | Rank |
|----------- |------- |-----------:|----------:|----------:|-----------:|-----:|
| UsingRange |   1000 |  0.2293 ns | 0.0360 ns | 0.0319 ns |  0.2242 ns |    1 |
| UsingIndex |   1000 |  0.2346 ns | 0.0387 ns | 0.0362 ns |  0.2264 ns |    2 |
|  UsingLinq |   1000 | 22.9351 ns | 0.2676 ns | 0.2235 ns | 22.8624 ns |    3 |
|            |        |            |           |           |            |      |
| UsingRange |  10000 |  0.2340 ns | 0.0398 ns | 0.0426 ns |  0.2195 ns |    1 |
| UsingIndex |  10000 |  0.2685 ns | 0.0374 ns | 0.0350 ns |  0.2711 ns |    2 |
|  UsingLinq |  10000 | 23.5026 ns | 0.1771 ns | 0.1570 ns | 23.5339 ns |    3 |
|            |        |            |           |           |            |      |
| UsingRange | 100000 |  0.2228 ns | 0.0332 ns | 0.0310 ns |  0.2183 ns |    1 |
| UsingIndex | 100000 |  0.3176 ns | 0.0442 ns | 0.1262 ns |  0.2681 ns |    2 |
|  UsingLinq | 100000 | 24.2564 ns | 0.5048 ns | 0.4958 ns | 24.0972 ns |    3 |
```

**`Tools`** : vs19, net 5.0
