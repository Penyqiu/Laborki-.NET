using System;
using System.Xml;
using System.Xml.Schema;

namespace Zad3
{
    internal static class Program
    {
        private static void Main()
        {
            var booksSettings = new XmlReaderSettings();
            booksSettings.Schemas.Add("http://www.contoso.com/books", @"../../schema.xsd");
            booksSettings.ValidationType = ValidationType.Schema;
            booksSettings.ValidationEventHandler += BookValidationHandler;

            var books = XmlReader.Create(@"../../books.xml", booksSettings);

            while (books.Read())
            {
                if (string.IsNullOrWhiteSpace(books.Value)) continue;
                
                Console.WriteLine($"Content: {books.Value}");
            }
        }

        private static void BookValidationHandler(object sender, ValidationEventArgs e)
        {
            Console.WriteLine($"{e.Severity}: {e.Message} ({e.Exception})");
        }
    }
}