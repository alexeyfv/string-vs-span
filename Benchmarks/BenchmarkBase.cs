namespace Bnchmrk.Benchmarks;

public abstract class BenchmarkBase
{
    protected string[] strings = default!;

    public virtual void Setup()
    {
        strings = Enumerable
            .Range(1, 100_000)
            .Select(_ => $"{Guid.NewGuid()}")
            .ToArray();
    }
}
