namespace SimpleFactory
{
    public static class DocumentExporterFactory
    {
        public static IDocumentExporter CreateExporter(string type)
        {
            return type.ToLower() switch
            {
                "pdf" => new PdfExporter(),
                "csv" => new CsvExporter(),
                "html" => new HtmlExporter(),
                _ => throw new ArgumentException($"Format not supported: {type}")
            };
        }
    }
}