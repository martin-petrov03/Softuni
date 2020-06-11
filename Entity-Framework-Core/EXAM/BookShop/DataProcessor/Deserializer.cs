namespace BookShop.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using BookShop.Data.Models;
    using BookShop.Data.Models.Enums;
    using BookShop.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedBook
            = "Successfully imported book {0} for {1:F2}.";

        private const string SuccessfullyImportedAuthor
            = "Successfully imported author - {0} with {1} books.";

        public static string ImportBooks(BookShopContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(BooksImportDto[]), new XmlRootAttribute("Books"));
            var objects = (BooksImportDto[])serializer.Deserialize(new StringReader(xmlString));
            StringBuilder sb = new StringBuilder();
            List<Book> books = new List<Book>();

            foreach (var dto in objects)
            {
                int genreValue = Int32.Parse(dto.Genre);
                if (genreValue < 1 || genreValue > 3)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Genre genre;
                if (!Enum.TryParse<Genre>(dto.Genre, out genre))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                DateTime publishedOn;
                if (!DateTime.TryParseExact(dto.PublishedOn, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out publishedOn))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (IsValid(dto))
                {
                    var book = new Book
                    {
                        Name = dto.Name,
                        Genre = genre,
                        Price = dto.Price,
                        Pages = dto.Pages,
                        PublishedOn = publishedOn
                    };

                    books.Add(book);               
                    sb.AppendLine(string.Format(SuccessfullyImportedBook, dto.Name, dto.Price));
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }
            }

            context.Books.AddRange(books);
            context.SaveChanges();
            return sb.ToString().Trim();
        }

        public static string ImportAuthors(BookShopContext context, string jsonString)
        {
            var authorDtos = JsonConvert.DeserializeObject<AuthorImportDto[]>(jsonString);
            var authors = new List<Author>();
            StringBuilder sb = new StringBuilder();

            int counter = 0;
            foreach (var dto in authorDtos)
            {
                if (IsValid(dto))
                {
                    int[] booksIds = context
                        .Books
                        .Select(b => b.Id)
                        .ToArray();

                    var author = new Author
                    {
                        FirstName = dto.FirstName,
                        LastName = dto.LastName,
                        Phone = dto.Phone,
                        Email = dto.Email                        
                    };

                    authors.Add(author);

                    string fullName = dto.FirstName + dto.LastName;
                    sb.AppendLine(String.Format(SuccessfullyImportedAuthor, fullName, dto.Books.Count));
                }
                else
                {
                    sb.AppendLine(ErrorMessage);
                }

                counter++;
            }

            context.Authors.AddRange(authors);
            context.SaveChanges();
            return sb.ToString().Trim();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}