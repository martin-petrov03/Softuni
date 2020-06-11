namespace BookShop.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using BookShop.Data.Models.Enums;
    using BookShop.DataProcessor.ExportDto;
    using Data;
    using Newtonsoft.Json;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportMostCraziestAuthors(BookShopContext context)
        {
            var authors = context
                .Authors                
                .Select(a => new
                {
                    AuthorName = $"{a.FirstName} {a.LastName}",
                    Books = a.AuthorBooks
                        .Select(ab => ab.Book)
                        .Select(b => new BookExportDto
                        {
                            BookName = b.Name,
                            BookPrice = b.Price
                        })
                        .OrderByDescending(b => b.BookPrice)
                        .ToList()
                })
                .OrderByDescending(a => a.Books.Count)
                .ToList();

            var result = JsonConvert.SerializeObject(authors, Formatting.Indented);
            return result;
        }

        public static string ExportOldestBooks(BookShopContext context, DateTime date)
        {
            var books = context
                .Books
                .Where(b => b.PublishedOn < date && b.Genre == Genre.Science)
                .Select(b => new ExportOldestBooksDto
                {
                    Name = b.Name,
                    Date = b.PublishedOn
                })
                .Take(10)
                .ToList();

            var serializer = new XmlSerializer(typeof(ExportOldestBooksDto[]), new XmlRootAttribute("Books"));

            var sb = new StringBuilder();

            serializer.Serialize(new StringWriter(sb), books);

            return sb.ToString();
        }
    }
}