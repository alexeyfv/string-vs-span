
BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4317/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2


 Method                                         | Mean       | Error   | StdDev  | Gen0     | Allocated |
----------------------------------------------- |-----------:|--------:|--------:|---------:|----------:|
 string.TrimStart()                             |   540.5 μs | 1.80 μs | 1.50 μs |        - |         - |
 'string.TrimStart(char trimChar)'              |   911.0 μs | 3.60 μs | 3.19 μs | 290.0391 |  607024 B |
 'string.TrimStart(char trimChars)'             | 1,204.1 μs | 4.54 μs | 3.54 μs | 568.3594 | 1188945 B |
 ReadOnlySpan<char>.TrimStart()                 |   546.4 μs | 2.38 μs | 1.99 μs |        - |         - |
 'ReadOnlySpan<char>.TrimStart(char trimChar)'  |   539.1 μs | 2.32 μs | 2.06 μs |        - |         - |
 'ReadOnlySpan<char>.TrimStart(char trimChars)' |   783.0 μs | 8.50 μs | 7.95 μs |        - |         - |
