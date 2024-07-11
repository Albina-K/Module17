namespace SingleResponsibility
{
    class Program
    {
        static void Main()
        {
            IExporter exporter = new PdfExporter();
            Document document = new Document();
            document.Text = "Hello Word";
            document.Export(exporter);
        }
    }
}