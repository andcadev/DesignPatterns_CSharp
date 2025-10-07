namespace SimpleFactory
{
    public class PdfExporter : IDocumentExporter
    {
        public void Export(string content, string filename)
        {
            Console.WriteLine($"[PDF] Content exported\n" +
                $"File: {filename}.pdf\n" +
                $"Content: {content}");
        }
    }
}