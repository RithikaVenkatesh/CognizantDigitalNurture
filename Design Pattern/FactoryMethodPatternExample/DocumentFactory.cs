using System;

namespace FactoryMethodPatternExample
{
    public class DocumentFactory
    {
        public static IDocument CreateDocument(string type)
        {
            switch (type.ToLower())
            {
                case "word":
                    return new WordDocument();
                case "pdf":
                    return new PdfDocument();
                case "excel":
                    return new ExcelDocument();
                default:
                    throw new ArgumentException("Invalid document type.");
            }
        }
    }
}
