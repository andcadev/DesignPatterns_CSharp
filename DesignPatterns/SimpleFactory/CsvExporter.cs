namespace SimpleFactory
{
    public class CsvExporter : IDocumentExporter
    {
        public void Export(string content, string filename)
        {
            Console.WriteLine($"[CSV] Content exported\n" +
                $"File: {filename}.csv\n" +
                $"Content: {content}");
        }
    }
}