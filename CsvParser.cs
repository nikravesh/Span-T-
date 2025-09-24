namespace Span.PracticalSample;
public class CsvParser
{
    public static (string name,uint age,string job) ParsLine(ReadOnlySpan<char> line)
    {
        var firstComma = line.IndexOf(',');
        var secondComma = line.Slice(firstComma+1).IndexOf(",");

        var name= line.Slice(0, firstComma);
        var age = line.Slice(firstComma + 1, secondComma - firstComma - 1);
        var job = line.Slice(secondComma + 1);

        return (name.ToString(), uint.Parse(age), job.ToString());
    }
}
