using System.Text.Json;
namespace KysectAcademyTask;

public class OutputInJson
{
    public void OutputResults(ComparisonResult comparisonResult, string resultPath)
    {
        using var fs = new FileStream(resultPath, FileMode.OpenOrCreate);
        JsonSerializer.SerializeAsync<ComparisonResult>(fs, comparisonResult);
    }
}