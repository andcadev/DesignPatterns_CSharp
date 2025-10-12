namespace SimpleFactory
{
    public class HtmlExporter : IDocumentExporter
    {
        public void Export(string content, string filename)
        {
            Console.WriteLine($"[HTML] Content exported\n" +
                $"File: {filename}.html\n" +
                $"Content: \n{content}");
        }
    }
}