namespace SimpleFactory
{
    public static class DocumentExporterFactory
    {
        // This is the implementation of the Simple Factory

        public static IDocumentExporter CreateExporter(string type)
        {
            // return the right object according to the string type 
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