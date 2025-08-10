using System;

namespace FactoryMethodPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the document type (Word / PDF / Excel): ");
            string? input = Console.ReadLine();

            if (input != null)
            {
                try
                {
                    IDocument document = DocumentFactory.CreateDocument(input);
                    document.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("No input provided.");
            }
        }
    }
}
