namespace Span.PracticalSample;
public class CsvParser
{
    public static (string name,uint age,string job) ParseWithSpan(ReadOnlySpan<char> line)
    {
        var firstComma = line.IndexOf(',');
        var secondComma = line.Slice(firstComma+1).IndexOf(",") + firstComma + 1;

        var name= line.Slice(0, firstComma);
        var age = line.Slice(firstComma + 1, secondComma - firstComma - 1);
        var job = line.Slice(secondComma + 1);

        return (name.ToString(), uint.Parse(age), job.ToString());
    }

    public static (string Name, int Age, string Job) ParseWithString(string line)
    {
        var parts = line.Split(',');
        return (parts[0], int.Parse(parts[1]), parts[2]);
    }
}
