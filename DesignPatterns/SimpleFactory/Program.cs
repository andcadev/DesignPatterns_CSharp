namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("====== BEGIN DEMO - ABSTRACT FACTORY ======");
            Console.WriteLine("===========================================");

            Console.WriteLine("Select export format (pdf, csv, html):");
            string format = Console.ReadLine() ?? string.Empty;

            string table =
                @"ID | Product    | Quantity | Price
---+------------+----------+-------
 1 | Item A     |    10    |  15.50
 2 | Item B     |     5    |  22.00
 3 | Item C     |     7    |  18.75";

            Console.WriteLine("------------------------------------");

            try
            {
                // Simple factory: instantiate the right object according to the user selection
                IDocumentExporter exporter = DocumentExporterFactory.CreateExporter(format);
                exporter.Export(table, "myFile") ;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine("------------------------------------");


            Console.WriteLine("===========================================");
            Console.WriteLine("======= END DEMO - ABSTRACT FACTORY =======");
            Console.WriteLine("===========================================");
        }
    }
}