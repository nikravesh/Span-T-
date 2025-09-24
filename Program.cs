
using Span.PracticalSample;

Console.WriteLine("Reading CSV with Span<T>...");
Console.WriteLine("------------------------------------------------");

var lines = await File.ReadAllLinesAsync("./data.csv");

foreach (var line in lines)
{
    var record =  CsvParser.ParsLine(line);

    Console.WriteLine($"Name: {record.name}, Age:{record.age}, Job: {record.job}");
    Console.WriteLine("------------------------------------------------");
}

Console.ReadKey();