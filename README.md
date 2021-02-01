# LastItemBenchDemo
```
Benchmarking various ways to get last item from collection (list, array)
```

In this demo, i m using [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) library in order to benchmark various ways of finding last item in a collection :
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

`Categories=Array`

```
|     Method |   Size |       Mean |     Error |    StdDev |        Min |        Max | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |------- |-----------:|----------:|----------:|-----------:|-----------:|-----:|------:|------:|------:|----------:|
| UsingRange |   1000 |  0.1891 ns | 0.0295 ns | 0.0262 ns |  0.1272 ns |  0.2313 ns |    1 |     - |     - |     - |         - |
| UsingIndex |   1000 |  0.2561 ns | 0.0327 ns | 0.0290 ns |  0.2136 ns |  0.3113 ns |    2 |     - |     - |     - |         - |
|  UsingLinq |   1000 | 22.9178 ns | 0.0745 ns | 0.0697 ns | 22.8118 ns | 23.0274 ns |    3 |     - |     - |     - |         - |
|            |        |            |           |           |            |            |      |       |       |       |           |
| UsingRange |  10000 |  0.2149 ns | 0.0089 ns | 0.0083 ns |  0.1920 ns |  0.2282 ns |    1 |     - |     - |     - |         - |
| UsingIndex |  10000 |  0.2809 ns | 0.0329 ns | 0.0352 ns |  0.2421 ns |  0.3590 ns |    2 |     - |     - |     - |         - |
|  UsingLinq |  10000 | 23.6629 ns | 0.2249 ns | 0.1994 ns | 23.4460 ns | 24.0720 ns |    3 |     - |     - |     - |         - |
|            |        |            |           |           |            |            |      |       |       |       |           |
| UsingIndex | 100000 |  0.2034 ns | 0.0082 ns | 0.0077 ns |  0.1910 ns |  0.2161 ns |    1 |     - |     - |     - |         - |
| UsingRange | 100000 |  0.2077 ns | 0.0178 ns | 0.0139 ns |  0.1954 ns |  0.2382 ns |    1 |     - |     - |     - |         - |
|  UsingLinq | 100000 | 22.3364 ns | 0.1540 ns | 0.1365 ns | 22.0174 ns | 22.4730 ns |    2 |     - |     - |     - |         - |
```

**`Tools`** : vs19, net 5.0
