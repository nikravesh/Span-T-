using BenchmarkDotNet.Attributes;

namespace Span.PracticalSample;
public class BenchmarkCsv
{
    private string[] _lines;

    [GlobalSetup]
    public void Setup()
    {
        _lines = File.ReadAllLines("data.csv");
    }

    [Benchmark]
    public void SpanParsing()
    {
        foreach (var line in _lines)
        {
            var record = CsvParser.ParseWithSpan(line.AsSpan());
        }
    }

    [Benchmark]
    public void StringSplitParsing()
    {
        foreach (var line in _lines)
        {
            var record = CsvParser.ParseWithString(line);
        }
    }
}
