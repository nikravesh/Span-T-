using BenchmarkDotNet.Running;

using Span.PracticalSample;

var summary = BenchmarkRunner.Run<BenchmarkCsv>();

Console.ReadKey();